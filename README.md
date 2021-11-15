# BlazorTemplate

Minimal Blazor template with WASM, MAUI, WinForms and WPF projects that share the same `razor`, `cs` and `css` files in a RCL.

`Index.razor`, `app.css`, `_Imports.razor` and `Main.razor` are all in RCL, only `index.html` is duplicated in the WASM, MAUI, WinForms and WPF projects.

You can define all your components and pages in the RCL.