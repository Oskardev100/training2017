
//Create a JSON Object that contains my products information.

var myCatalog =
    {
        "MyCollection": {
            "Product1":
            {
                "id": 0,
                "title": "myTitle0",
                "description": "myDescription",
                "imgUrl": "Images/img_001.jpg"
            },
            "Product2":
            {
                "id": 1,
                "title": "myTitle1",
                "description": "myDescription",
                "imgUrl": "Images/img_001.jpg"
            },
            "Product3":
            {
                "id": 2,
                "title": "myTitle2",
                "description": "myDescription",
                "imgUrl": "Images/img_001.jpg"
            }
        }
    }

//Your jSON Object
var myCatalog2 = {
    "Product1":
    {
        "id": 0,
        "title": "myTitle0",
        "description": "myDescription",
        "imgUrl": "Images/img_001.jpg"
    },
    "Product2":
    {
        "id": 1,
        "title": "myTitle1",
        "description": "myDescription",
        "imgUrl": "Images/img_002.jpg"
    },
    "Product3":
    {
        "id": 2,
        "title": "myTitle2",
        "description": "myDescription",
        "imgUrl": "Images/img_003.jpg"
    }
}

//Ready: After HTML loads
$(document).ready(function () {
    $("#DynamicHTML").append(buildMyProduct2(myCatalog2));
});

//Dynamic build your collection
function buildMyProduct2(obj) {
    var html = "";
    $.each(obj, function (element, object) {
        html += "<div class='Catalog ProducItem'>";
        html += "<div><a href='details.html?id=" + object.id + "'>" + object.title + "</a></div>";
        html += "<div><img class='Catalog' src='" + object.imgUrl + "' /></div>";
        html += "<div>" + object.description + "</div></div>";
    });
    return html;
}




function buildMyProduct() {
    var html = "<div class='Catalog ProducItem'>";
    html += "<div>" + myCatalog.MyCollection.Product1.title + "</div>";
    html += "<div><img class='Catalog' src='" + myCatalog.MyCollection.Product1.imgUrl + "' /></div>";
    html += "<div>" + myCatalog.MyCollection.Product1.description + "</div>";

    return html;
}
