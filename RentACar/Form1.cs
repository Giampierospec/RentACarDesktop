using MaterialSkin;
using MaterialSkin.Controls;
using RentACar.Repository;
using System.Drawing;
using System.Windows.Forms;

namespace RentACar
{
    public partial class LoginForm : MaterialForm
    {
        private UserRepo _repo;

        public LoginForm()
        {
            InitializeComponent();
            _repo = new UserRepo();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void LoginForm_Load(object sender, System.EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            btnLogin.Cursor = Cursors.WaitCursor;
            userTxt.ReadOnly = true;
            passTxt.ReadOnly = true;
           var userExists =  _repo.CheckIfUserExists(new Models.LoginModel()
            {
                Usuario = userTxt.Text.Trim(),
                Password = passTxt.Text.Trim()
            });
            if (!userExists)
            {
                userTxt.ReadOnly = false;
                passTxt.ReadOnly = false;
                errLabel.ForeColor = Color.Red;
                errLabel.Text = $"El usuario {userTxt.Text.Trim()} no existe  o la contraseña es incorrecta";
            }
            
        }

        private void btnLogin_MouseHover(object sender, System.EventArgs e)
        {
            btnLogin.Cursor = Cursors.Hand;
        }
    }
}
