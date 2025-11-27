# How to Programmatically Select All DropDown Items in WinForms SfComboBox
This example demonstrates how to programmatically select all items in the Syncfusion WinForms SfComboBox control. The SfComboBox supports advanced features like multi-selection, auto-complete, and data binding. Selecting all items programmatically is useful for scenarios such as applying bulk actions or initializing default selections.

## Why This Is Useful
- **Batch Operations**: Apply global settings to all items.
- **Default Selections**: Pre-select all items when loading data.
- **Improved UX**: Avoid manual selection for large lists.

## Key Steps
- Set _ComboBoxMode_ to MultiSelection to allow multiple selections.
- Bind the data source to the SfComboBox.
- Iterate through all items and add them to _CheckedItems_ collection.
- Refresh the UI to reflect the changes.

## Code example

**Designer**
```C#
#region Windows Form Designer generated code
private void InitializeComponent()
{
    this.sfComboBox1 = new Syncfusion.WinForms.ListView.SfComboBox();
    this.button1 = new System.Windows.Forms.Button();
    ((System.ComponentModel.ISupportInitialize)(this.sfComboBox1)).BeginInit();
    this.SuspendLayout();

    // sfComboBox1
    this.sfComboBox1.Location = new System.Drawing.Point(445, 143);
    this.sfComboBox1.Name = "sfComboBox1";
    this.sfComboBox1.Size = new System.Drawing.Size(257, 57);
    this.sfComboBox1.TabIndex = 0;

    // button1
    this.button1.Location = new System.Drawing.Point(33, 162);
    this.button1.Name = "button1";
    this.button1.Size = new System.Drawing.Size(211, 38);
    this.button1.Text = "Select Programmatically";
    this.button1.Click += new System.EventHandler(this.button1_Click);

    // Form1
    this.ClientSize = new System.Drawing.Size(800, 450);
    this.Controls.Add(this.button1);
    this.Controls.Add(this.sfComboBox1);
    this.Text = "SfComboBox_CheckedItems";

    ((System.ComponentModel.ISupportInitialize)(this.sfComboBox1)).EndInit();
    this.ResumeLayout(false);
}
#endregion
```

**Logic**
```C#

public Form1()
{
    InitializeComponent();

    // Bind data source
    sfComboBox1.DataSource = GetTable();
    sfComboBox1.DisplayMember = "Patient";
    sfComboBox1.ValueMember = "Drug";
    sfComboBox1.ComboBoxMode = ComboBoxMode.MultiSelection;
    this.StartPosition = FormStartPosition.CenterScreen;
}

private static DataTable GetTable()
{
    DataTable table = new DataTable();
    table.Columns.Add("Dosage", typeof(int));
    table.Columns.Add("Drug", typeof(string));
    table.Columns.Add("Patient", typeof(string));
    table.Columns.Add("Date", typeof(DateTime));

    table.Rows.Add(25, "Indocin", "David", DateTime.Now);
    table.Rows.Add(50, "Enebrel", "Sam", DateTime.Now);
    table.Rows.Add(10, "Hydralazine", "Christoff", DateTime.Now);
    table.Rows.Add(21, "Combivent", "Janet", DateTime.Now);
    table.Rows.Add(100, "Dilantin", "Melanie", DateTime.Now);
    return table;
}

private void button1_Click(object sender, EventArgs e)
{
    foreach (var item in sfComboBox1.DropDownListView.View.Items.ToList())
    {
        sfComboBox1.DropDownListView.CheckedItems.Add(item);
    }
}
```

## Notes
- Ensure ComboBoxMode is set to MultiSelection for multiple selections.
- Use CheckedItems collection to programmatically select items.
- This approach works for both static and dynamic data sources.
