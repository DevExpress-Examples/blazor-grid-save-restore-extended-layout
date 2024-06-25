<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/747202637/23.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1212928)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Grid for Blazor - Save and load extended information about the Grid layout

The DevExpress [Blazor Grid](https://docs.devexpress.com/Blazor/403143/components/grid) allows you to save layout information between application sessions. This information includes only settings that a user can change in the built-in UI. This example illustrates how to extend the default layout object to save additional information about the Grid layout.

![Save and Restore Extended Layout ](save-restore-extended-layout.gif)

In this example, the Grid displays the following buttons in the [toolbar](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.ToolbarTemplate):

**Filter Row**  
Changes the [ShowFilterRow](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.ShowFilterRow) property value.

**Group Panel**  
Changes the [ShowGroupPanel](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.ShowGroupPanel) property value.

**Search Box**  
Changes the [ShowSearchBox](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.ShowSearchBox) property value.

**Column Chooser**  
Shows the [column chooser](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.ShowColumnChooser).

**Save Layout**  
Saves default layout object and values of [ShowFilterRow](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.ShowFilterRow), [ShowGroupPanel](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.ShowGroupPanel), and [ShowSearchBox](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.ShowSearchBox) properties to the [local storage](https://developer.mozilla.org/en-US/docs/Web/API/Window/localStorage).

**Load Layout**  
Loads layout settings from the [local storage](https://developer.mozilla.org/en-US/docs/Web/API/Window/localStorage) and applies them to the Grid.

## Files to Review

- [Weather.razor](./CS/ExtendedGridLayout/Pages/Weather.razor)
- [GridExtendedLayout.cs](./CS/ExtendedGridLayout/Data/GridExtendedLayout.cs)
- [LocalStorageHelper.cs](./CS/ExtendedGridLayout/Data/LocalStorageHelper.cs)
- [Program.cs](./CS/ExtendedGridLayout/Program.cs)

## Documentation

* [GridPersistentLayout](https://docs.devexpress.com/Blazor/DevExpress.Blazor.GridPersistentLayout)

## More Examples

- [Grid for Blazor - Save and load layout information](https://github.com/DevExpress-Examples/blazor-DxGrid-save-restore-layout)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=blazor-grid-save-restore-extended-layout&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=blazor-grid-save-restore-extended-layout&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
