using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoDatabase
{
    public partial class UpdateClientForm : Form
    {
        DataController data;
        int clientId;
        Client client = null;

        public bool isPerson = false;
        public UpdateClientForm(object id)
        {
            InitializeComponent();
            clientId = (int)id;
        }

        private void UpdateClientForm_Load(object sender, EventArgs e)
        {
            data = new DataController();
            client = data.findClient(clientId);
            if (!client.IsCompany)
            {
                textClient1.Text = "Vardas";
                textClient2.Text = "Pavarde";
                client = data.findClient(clientId);
            }else if (client.IsCompany)
            {
                textClient1.Text = "Pavadinimas";
                textClient2.Text = "Kodas";
                client = data.findClient(clientId);
            }
            fillTextFields();
        }

        private void fillTextFields()
        {
            if (!client.IsCompany)
            {
                textBoxClientName.Text = client.Name;
                textBoxClientSurname.Text = client.Surname;
                textBoxAddress.Text = client.Adress;
                textBoxTelephone.Text = client.Telephone;
            }else if (client.IsCompany)
            {
                textBoxClientName.Text = client.Name;
                textBoxClientSurname.Text = client.Code;
                textBoxAddress.Text = client.Adress;
                textBoxTelephone.Text = client.Telephone;
            }
        }

        private void buttonUpdateClient_Click(object sender, EventArgs e)
        {
            data.updateClientData(clientId, textBoxClientName.Text, textBoxClientSurname.Text, textBoxClientSurname.Text, textBoxAddress.Text, textBoxTelephone.Text);
            this.Dispose();
        }
    }
}
