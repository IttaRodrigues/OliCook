@model OliCook.Models.Categoria

@{
    ViewData["Title"] = "Create";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";
}

<h1>Create</h1>

<h4>Categoria</h4>
<hr />
<div class="row">
    <div class="col-md-4">
        <form asp-action="Create" method="post" enctype="multipart/form-data">
            <div asp-validation-summary="ModelOnly" class="text-danger"></div>
            <div class="form-group">
                <label asp-for="Nome" class="control-label"></label>
                <input asp-for="Nome" class="form-control" />
                <span asp-validation-for="Nome" class="text-danger"></span>
            </div>
            <div class="form-group">
                <label asp-for="Foto" class="control-label"></label>
                <input asp-for="Foto" class="form-control" />
                <span asp-validation-for="Foto" class="text-danger"></span>
            </div>
            <div class="form-group form-check">
                <label class="form-check-label">
                    <input class="form-check-input" asp-for="ExibirHome" /> @Html.DisplayNameFor(model => model.ExibirHome)
                </label>
            </div>
            <div class="form-group">
                <input type="submit" value="Salvar" class="btn btn-primary" />
                <a class="btn btn-danger ms-2" asp-action="Index">Cancelar</a>
            </div>
        </form>
    </div>
</div>

@section Scripts {
    <script>
        window.addEventListener('load', function()){
            document.querySelector('input[type=file]')
            .addEventListener('change', function())
            
        }
    </script>

}
