# How to Programmatically Select All DropDownItems in SfComboBox
This repository demonstrates how to programmatically select all items in the DropDown list of the Syncfusion SfComboBox control in a Windows Forms application. The SfComboBox is a powerful UI component that supports advanced features like multi-selection, auto-complete, and data binding. In scenarios where you need to select all items at once—such as applying bulk actions or initializing default selections—this sample provides a clear and practical approach.

## Key Features Demonstrated in This Sample
    • Enable multi-selection mode in SfComboBox.
    • Programmatically select all items in the DropDown list using the SelectedItems collection.
    • Handle scenarios where the data source is dynamically loaded.
    • Ensure the UI reflects the selection state immediately after applying changes.
    
## Steps to Select All Items Programmatically
    1. Set the ComboBoxMode property to MultiSelection to allow multiple selections.
    2. Access the SelectedItems property and add all items from the data source.
    3. Refresh the control to update the UI.

This approach ensures that all items in the DropDown are selected without requiring manual user interaction. It is particularly useful for applications that need to apply global settings or perform batch operations.
