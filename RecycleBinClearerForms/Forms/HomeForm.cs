using System.Runtime.InteropServices;

namespace RecycleBinClearerForms
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        // External method from the Shell32.dll to access the recycle bin
        [DllImport("Shell32.dll", CharSet = CharSet.Unicode)]
        static extern uint SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath, Enums.RecycleFlags dwFlags);


        private void EmptyButton_Click(object sender, EventArgs e)
        {
            // Ask if they are sure
            var choice = MessageBox.Show("You are about to empty your Recycle Bin, are you sure?", "Warning!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // If they aren't sure break out of the method. 
            if (choice == DialogResult.No)
            {
                MessageBox.Show("Operation aborted", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }  
            
            // Otherwise clear the bin
            ClearTrash();
        }

        private void ClearTrash()
        {
            try
            {
                // Call the external method to actually clear the bin, passing in the enum for no confirmation then alert user
                uint IsSuccess = SHEmptyRecycleBin(IntPtr.Zero, null, Enums.RecycleFlags.SHRB_NOCONFIRMATION);
                MessageBox.Show("The recycle bin has been successfully recycled!", "Clear recycle bin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"The recycle bin couldn't be recycled \n Message: {ex.Message}","Clear recycle bin", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
