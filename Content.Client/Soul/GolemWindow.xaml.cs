using Robust.Client.UserInterface.CustomControls;
using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.XAML;
using Robust.Client.UserInterface.Controls;

namespace Content.Client.Soul
{
    [GenerateTypedNameReferences]
    public sealed partial class GolemWindow : DefaultWindow
    {
        public event Action<string>? OnNameEntered;
        public event Action<string>? OnMasterEntered;
        public event Action<BaseButton.ButtonEventArgs>? OnInstallButtonPressed;


        public GolemWindow()
        {
            RobustXamlLoader.Load(this);

            InstallButton.OnPressed += a => OnInstallButtonPressed?.Invoke(a);
            NameLineEdit.OnTextEntered += e => OnNameEntered?.Invoke(e.Text);
            MasterLineEdit.OnTextEntered += e => OnMasterEntered?.Invoke(e.Text);
        }

        public void SetCurrentName(string name)
        {
            NameLineEdit.Text = name;
        }

        public void SetCurrentMaster(string master)
        {
            MasterLineEdit.Text = master;
        }
    }
}
