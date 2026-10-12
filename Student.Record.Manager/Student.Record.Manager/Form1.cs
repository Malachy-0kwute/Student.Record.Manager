using MaterialSkin;
using MaterialSkin.Controls;

namespace Student.Record.Manager
{
    public partial class Form1 : MaterialForm
    {

        public Form1()
        {
            InitializeComponent();

            InitializeMaterialSkin();

            Load += (s, e) =>
            {
                appPanel.Controls.Clear();
                appPanel.Controls.Add(new StudentListControl());
            };
        }

        private void InitializeMaterialSkin()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        public void ShowControl(UserControl control)
        {
            appPanel.Controls.Clear();
            appPanel.Controls.Add(control);
        }
    }
}
