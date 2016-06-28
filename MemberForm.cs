//Rebecka Åkhagen Holm
//V. 1.0
using Library.Models;
using Library.Repositories;
using Library.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class MemberForm : Form
    {
        MemberService _memberService;
        Member m1 = new Member();
        LibraryForm form = new LibraryForm();

        public MemberForm(MemberService mm)
        {
            InitializeComponent();
            RepositoryFactory repoFactory = new RepositoryFactory();

            _memberService = mm;
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            m1.PersonalId = txtPId.Text;
            m1.Name = txnName.Text;
            _memberService.Add(m1);
            _memberService.OnChanged(this, EventArgs.Empty);
            //form.ListAllMembers();
            this.Close();
        }

        
    }
}
