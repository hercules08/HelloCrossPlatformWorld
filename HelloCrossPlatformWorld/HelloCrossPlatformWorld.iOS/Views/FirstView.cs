using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using HelloCrossPlatformWorld.Core.ViewModels;

namespace HelloCrossPlatformWorld.iOS.Views
{
    [MvxFromStoryboard]
    public partial class FirstView : MvxViewController
    {
        public FirstView(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<FirstView, FirstViewModel>();
            set.Bind(Label).To(vm => vm.Name);
            set.Bind(TextField).To(vm => vm.Name);
            set.Bind(SayHelloButton).To(vm => vm.SayHelloCommand);
            set.Apply();
        }
    }
}
