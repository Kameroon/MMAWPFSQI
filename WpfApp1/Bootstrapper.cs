using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Unity;

namespace WpfApp1
{
    public class Bootstrapper : UnityBootstrapper
    {
        public override void Run(bool runWithDefaultConfiguration)
        {
            base.Run(runWithDefaultConfiguration);
        }

        protected override DependencyObject CreateShell()
        {
            return Container.TryResolve<Shell>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow = (Window)Shell;
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();
            try
            {
                //// -- Apres avoir créer un module FichesPaieModule --
                //Type FichesPaieModuleModuleType = typeof(FichesPaieModule);
                //ModuleCatalog.AddModule(new ModuleInfo
                //{
                //    ModuleName = FichesPaieModuleModuleType.Name,
                //    ModuleType = FichesPaieModuleModuleType.AssemblyQualifiedName
                //});
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
                throw;
            }
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();

            ////Container.RegisterType<IDialogService, DialogService>();
            ////Container.RegisterType<IEmailMessage, EmailMessage>();
            //Container.RegisterType<IUser, User>();

            //Container.RegisterTypeForNavigation<UserDetail>("UserDetail");
        }
    }

    #region -- Nex version --
    public static class UnityExtensions
    {
        public static void ResgisterTypeForNavigation<T>(this IUnityContainer container, string name)
        {
            container.RegisterType(typeof(object), typeof(T), name);
        }
    }
    #endregion
}
