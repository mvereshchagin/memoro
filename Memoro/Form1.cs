using Data.Entities;
using Data.Repositories;
//using GoogleApi.Entities.Translate.Translate.Response;
using System.Configuration;


namespace Memoro
{
    public partial class Form1 : Form
    {
        User currentUser;
        IUserRepository userRepo = Configuration.Container.GetInstance<IUserRepository>();
        IWordRepository wordRepo = Configuration.Container.GetInstance<IWordRepository>();
        IAssociationRepository assRepo = Configuration.Container.GetInstance<IAssociationRepository>();
        IUserWordAssociationRepository uwaRepo = Configuration.Container.GetInstance<IUserWordAssociationRepository>();

        public Form1()
        {
            InitializeComponent();
        }
        private void btConnect_Click(object sender, EventArgs e)
        {
            try
            {
                var user = userRepo.Get(x => x.Name == tbName.Text).SingleOrDefault();
                if(user != null)
                {
                    currentUser = user;
                    LoadWords();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void LoadAss(int wordId, int userId)
        {
            lbAss.Items.Clear();
            var assIds = uwaRepo.Get(x => (x.UserId == userId) && (x.WordId == wordId))
                .Select(x => x.AssociationId)
                .ToList();
            var assoc = assRepo.Get(x => assIds.Contains(x.Id))
                .Select(x => x.Text);

            foreach (var ass in assoc)
            {
                lbAss.Items.Add(ass);
            }
        }

        private void LoadWords()
        {
            lbWords.Items.Clear();
            lbAss.Items.Clear();

            var wordIds = uwaRepo.Get(x => x.UserId == currentUser.Id)
                .Select(x=>x.WordId)
                .ToList();
            var words = wordRepo.Get(x => wordIds.Contains(x.Id))
                .Select(x => x.Text);

           foreach (var word in words)
           {
               lbWords.Items.Add(word);
           }
        }

        private void lbWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbAss.Items.Clear();
            var wordTxt = lbWords.Items[lbWords.SelectedIndex].ToString();
            var word = wordRepo.Get(x => x.Text == wordTxt).SingleOrDefault();
            LoadAss(word.Id, currentUser.Id);
        }
        
        private void AddWordBtn_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void addAssBtn_Click(object sender, EventArgs e)
        {

        }

        private void lbAss_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void tbNewWord_TextChanged(object sender, EventArgs e)
        {

        }
    }
}