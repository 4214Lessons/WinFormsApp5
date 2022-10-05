using System.Text;

namespace WinFormsApp5;

public partial class FormEdit : Form
{
    public Product? EditProduct { get; set; }
    private bool _hasChanged = false;



    public FormEdit(Product product)
    {
        InitializeComponent();

        EditProduct = product;
        FillTextBoxText();
    }




    private void FormEdit_Load(object sender, EventArgs e)
        => FillTextBoxText();


    private void FillTextBoxText()
    {
        if (EditProduct is null)
            return;

        txt_name.Text = EditProduct.Name;
        txt_price.Text = EditProduct.Price.ToString();
        txt_discount.Text = EditProduct.Discount.ToString();

        _hasChanged = false;
    }



    public DialogResult ShowDialog(Product product)
    {
        EditProduct = product;
        FillTextBoxText();

        return ShowDialog();
    }



    private void btn_save_Click(object sender, EventArgs e)
    {
        if (!_hasChanged)
        {
            DialogResult = DialogResult.OK;
            return;
        }


        StringBuilder sb = new();

        if (string.IsNullOrWhiteSpace(txt_name.Text))
            sb.Append("*Name is wrong\n");

        if (!decimal.TryParse(txt_price.Text, out decimal price))
            sb.Append("*Price is wrong\n");

        if (!byte.TryParse(txt_discount.Text, out byte discount))
            sb.Append("*Discount is wrong\n");


        if(sb.Length > 0)
        {
            MessageBox.Show(sb.ToString(), 
                            "Errors", 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Error);
            return;
        }

        if (EditProduct is null)
            return;


        EditProduct.Name = txt_name.Text;
        EditProduct.Price = price;
        EditProduct.Discount = discount;


        DialogResult = DialogResult.OK;

        // Close();
        // Hide();
        // Show();
    }

    private void btn_cancel_Click(object sender, EventArgs e)
      => DialogResult = DialogResult.Cancel;

    private void txt_TextChanged(object sender, EventArgs e)
        => _hasChanged = true;
}