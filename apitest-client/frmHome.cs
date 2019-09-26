using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace apitest_client
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string url = "http://" + txtUrl.Text + "/version";

            // Create new request
            WebRequest request = WebRequest.Create(url);

            // Get response for request
            string response = getResponse(request);

            // Converting json to an object
            dynamic info = JsonConvert.DeserializeObject(response);
            txtVersion.Text = info.version;

            // Output debugging information
            setDebugInformation("GET", url, response);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string url = "http://" + txtUrl.Text + "/version";
            string version = txtVersion.Text;

            // Create new request
            WebRequest request = WebRequest.Create(url + "?version=" + version);
            request.Method = "POST"; // Set request method to POST

            // Get response for request
            string response = getResponse(request);

            setDebugInformation("POST", request.RequestUri.ToString(), response);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtVersion.Clear();

            lblRecentAction.Text = "Action: Version field cleared";
            lblResponse.Text = "Response: No response";
        }

        /// <summary>
        /// Executes a web request and returns the response from the server.
        /// </summary>
        /// <param name="request">The webrequest for which there needs to be a response fetched.</param>
        /// <returns></returns>
        private string getResponse(WebRequest request)
        {
            WebResponse response = request.GetResponse();

            using (Stream dataStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);

                return reader.ReadToEnd();
            }
        }

        /// <summary>
        /// Set the debug information in the form
        /// </summary>
        /// <param name="action">The type of request</param>
        /// <param name="url">The url to which the request is made</param>
        /// <param name="response">The response given by the server</param>
        private void setDebugInformation(string action, string url, string response)
        {
            lblRecentAction.Text = $"Action: {action}\nURL: {url}";
            lblResponse.Text = $"Response: {response}";
        }
    }
}
