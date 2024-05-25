using GalaSoft.MvvmLight.Ioc;
using MediaApp_WPF.Ioc;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Configuration;
using System.Data;
using System.Windows;

namespace MediaApp_WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public CompositionContainer _container;
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            WindowsAppIoc.InitializeIoc();
            ////var catalog = new AggregateCatalog();
            ////// Adds all the parts found in the same assembly as the Program class.
            ////catalog.Catalogs.Add(new AssemblyCatalog(typeof(App).Assembly));

            ////// Create the CompositionContainer with the parts in the catalog.
            ////_container = new CompositionContainer(catalog);
            ////_container.ComposeParts(this);
        }
    }

}
