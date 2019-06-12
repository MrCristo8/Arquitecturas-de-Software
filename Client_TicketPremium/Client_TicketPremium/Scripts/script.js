$(document).ready(function () {
    $('[data-toggle=tooltip]').tooltip();
});
function cambiar(partido, cantidades, index, localidad) {
    var url = "http://localhost:8080/TicketPremium/FacturaServlet?";
    for (var i = 0; i < cantidades.length; i++) {
        if (i === index) {
            var cant = "cantidad" + i;
            url += "cantidad" + i + "=" + document.getElementById(cant).value + "&";
        } else {
            url += "cantidad" + i + "=" + cantidades[i] + "&";
        }
    }
    url += "partido=" + partido + "&localidad=" + localidad;
    location.replace(url);
}
