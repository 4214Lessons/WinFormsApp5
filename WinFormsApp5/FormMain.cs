namespace WinFormsApp5;

public partial class FormMain : Form
{
    private Product? _selectedProduct = null;


    public FormMain()
    {
        InitializeComponent();
    }



    private void btn_load_Click(object sender, EventArgs e)
    {
        _selectedProduct = new()
        {
            Id = 1,
            Name = "Iphone 14 Pro Max",
            Price = 3400,
            Discount = 0
        };

        FillTextBoxText();
    }

    

    private void btn_edit_Click(object sender, EventArgs e)
    {
        if (_selectedProduct is null)
            return;


        // // Way 1: with Propery or Field
        // FormEdit formEdit = new FormEdit();
        // formEdit.EditProduct = _selectedProduct;
        // DialogResult result = formEdit.ShowDialog();
        // 
        //// formEdit.Show();







        // Way 2: with Constructor
        FormEdit formEdit = new FormEdit(_selectedProduct);
        DialogResult result = formEdit.ShowDialog();






        // // Way 3: with Method Overload (ShowDialog())
        // FormEdit formEdit = new FormEdit();
        // DialogResult result = formEdit.ShowDialog(_selectedProduct);







        if (result == DialogResult.OK) 
            FillTextBoxText();
        else
            MessageBox.Show("Cancel", 
                            "Information", 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);

    }


    private void FillTextBoxText()
    {
        txt_id.Text = _selectedProduct?.Id.ToString();
        txt_name.Text = _selectedProduct?.Name;
        txt_price.Text = _selectedProduct?.Price.ToString();
        txt_discount.Text = _selectedProduct?.Discount.ToString();
    }
}