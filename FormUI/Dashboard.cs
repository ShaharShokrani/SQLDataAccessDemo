using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Dashboard : Form
    {
        List<Post> posts = new List<Post>();

        public Dashboard()
        {
            InitializeComponent();

            postsFoundListbox.DataSource = posts;
            postsFoundListbox.DisplayMember = "FullInfo";
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            posts = db.GetPosts(postTitleText.Text);

            postsFoundListbox.DataSource = posts;
            postsFoundListbox.DisplayMember = "FullInfo";
        }
    }
}
