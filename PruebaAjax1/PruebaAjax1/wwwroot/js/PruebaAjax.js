function MostrarTexto() {
    var url = "@Url.Action('ImprimeTexto', 'Home')";
    var theObject = new XMLHttpRequest();
    theObject.open('GET', 'HomeController.cs', true);
    theObject.setRequestHeader('Content-type', 'application/x-ww-form-urlencoded');
    theObject.onreadystatechange = function () {
        console.log(theObject.responseText);
    }
    theObject.send();
}