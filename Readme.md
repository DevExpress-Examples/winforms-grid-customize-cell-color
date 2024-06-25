<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128631431/12.2.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4612)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms Data Grid - Customize cell appearance

Handle the [GridView.RowCellStyle](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Grid.GridView.RowCellStyle) event to customize appearance settings of cells based on a specific condition.

This example demonstrates how to create a helper class that handles the `RowCellStyle` event and makes it easy to specify a cell color:

```csharp
private CellColorHelper _CellColorHelper;
public Form1() {
    InitializeComponent();
    gridControl1.DataSource = CreateTable(20);
    _CellColorHelper = new CellColorHelper(gridView1);
}
private void simpleButton1_Click(object sender, EventArgs e) {
    _CellColorHelper.SetCellColor(Convert.ToInt32(spinEdit1.Value), gridView1.Columns[Convert.ToInt32(spinEdit2.Value)], colorEdit1.Color);
}
```

![WinForms Data Grid - Customize cell appearance](https://raw.githubusercontent.com/DevExpress-Examples/how-to-set-a-cell-color-e4612/12.2.7%2B/media/winforms-grid-cell-appearance.png)


## Files to Review

* [CellColorHelper.cs](./CS/CellColorHelper.cs) (VB: [CellColorHelper.vb](./VB/CellColorHelper.vb))
* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))


## Documentation

* [Appearance and Conditional Formatting](https://docs.devexpress.com/WindowsForms/115548/controls-and-libraries/data-grid/appearance-and-conditional-formatting)


## See Also

* [Appearances and Skins - DevExpress WinForms Cheat Sheet﻿](https://supportcenter.devexpress.com/ticket/details/t904174/appearances-and-skins-winforms-cheat-sheet)
* [Troubleshooting - Skins and Skin Editor﻿](https://supportcenter.devexpress.com/ticket/details/t928562/devexpress-winforms-troubleshooting-skins-and-skin-editor)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-customize-cell-color&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-customize-cell-color&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
