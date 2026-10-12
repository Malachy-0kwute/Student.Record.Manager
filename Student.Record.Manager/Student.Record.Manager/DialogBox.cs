using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.VisualBasic.Devices;

namespace Student.Record.Manager
{
    public partial class DialogBox : MaterialForm
    {
        public DialogBox()
        {
            InitializeComponent();

            InitializeMaterialSkin();
        }

        private void InitializeMaterialSkin()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
