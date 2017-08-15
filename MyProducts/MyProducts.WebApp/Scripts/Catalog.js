
//Create a JSON Object that contains my products information.

//Ready: After HTML loads
$(document).ready(function () {
    $("#DynamicHTML").append(buildMyProduct(JSONCatalog));
   // LoadMySimpleJson();

});

////Reading Simple JSON 
//function LoadMySimpleJson()
//{
//    var myJsonObj = mySimpleJson;
//    var myJsonObj = myJSONCollection1;
//    var myJsonObj = myJSONCollection2;

//    //$.each(mySimpleJson, function (element, object) {

//    //});
//}

//Dynamic build your collection
function buildMyProduct(obj) {
    var html = "";
    $.each(obj, function (element, object) {
        html += "<div><a href='details.html?id = " + object.id + "'>" + object.title+"</a></div>"
        //html += "<div><img class='Catalog' src='" + object.imgUrl + "' /></div>";
        html += "<div><img src='" + object.imgUrl + "' /></div>";
        html += "<div>" + object.description + "</div>";
        html += "<div>" + object.model + "</div>";
        html += "<div>" + object.price + "</div>";
    });
    return html;
}
