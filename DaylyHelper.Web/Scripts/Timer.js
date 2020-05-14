function Czas()
{
    var dt = new Date();
    $('#Time').val(dt.toLocaleTimeString());
    setTimeout("displaytime()", 1000;)
}