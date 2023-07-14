function HabilitarCampos() {
    document.getElementById("cuil").readOnly = false;
    document.getElementById("ApellidoYNombre").readOnly = false;
    /*document.getElementById("FechaNacimiento").disabled = false;*/
    document.getElementById("botonAgregar").style.display = "";

    document.getElementById('habilitar').style.display = 'none';

}
function ModalEliminar() {
    var modal = document.getElementById('myModal');
    $(modal).modal('show');
}
$("#hide").click(function () {
    $("#myModal").modal("hide");
});