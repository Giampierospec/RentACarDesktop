using MaterialSkin;
using MaterialSkin.Controls;
using RentACar.Repository;
using System.Drawing;
using System.Threading;
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
            Cursor = Cursors.WaitCursor;
            btnLogin.Cursor = Cursors.WaitCursor;
            Utils.Validate.LockControls(this);
            Utils.Validate.LockBtns(this);
           var user =  _repo.GetUserByEmailAddress(new Models.LoginModel()
            {
                Usuario = userTxt.Text.Trim(),
                Password = passTxt.Text.Trim()
            });
            if (user == null)
            {
                Utils.Validate.UnLockControls(this);
                Utils.Validate.EnableBtns(this);
                errLabel.ForeColor = Color.Red;
               MessageBox.Show($"El usuario {userTxt.Text.Trim()} no existe  o la contraseña es incorrecta");
            }
            else
            {
                Thread.Sleep(2000);
                Hide();
                var mainForm = new MainForm(user.Id);
                mainForm.ShowDialog();
                Close();
            }
            
        }

        private void btnLogin_MouseHover(object sender, System.EventArgs e)
        {
            btnLogin.Cursor = Cursors.Hand;
        }
    }
}
