// function DeleteBlog() {
    //     var request = new XMLHttpRequest();
    //     select = document.getElementById("deleteDiv");
    //     id = select.options[select.selectedIndex].value;
    //     url = "/api/blogsapi/" + id;
    //     request.open("DELETE", url, false);
    //     request.send();
    // }

    // function CreateBlog() {
    //     urlText = document.getElementById("createDiv").value;

    //     var xmlhttp = new XMLHttpRequest();   // new HttpRequest instance
    //     xmlhttp.open("POST", "/api/blogsapi/");
    //     xmlhttp.setRequestHeader("Content-Type", "application/json;charset=UTF-8");
    //     xmlhttp.send(JSON.stringify({ url: urlText }));
    // }

    function LoadBlogs() {
        var myObj, i, j, x, x2 = "";
        var request = new XMLHttpRequest();
        request.open("GET", "/api/ToursFull/", false);
        request.send();

        myObj = JSON.parse(request.responseText);
        x = "";
        for (i in myObj) {
            x += "<div class=\"row tour border-top\">";

            x += "<div class=\"col\">";
            x += "<img class=\"img-thumbnail\" src=\"" + myObj[i].touristDestination.photo.urlLlink +"\" width=\"100%\" height=\"100%\">";
            x += "</div>";

            x += "<div class=\"col\">";
            x += "<h4>" + myObj[i].touristDestination.hotelName + "</h4>";
            if (myObj[i].touristDestination.numberStars != null) {
                for (var j = 0; j < myObj[i].touristDestination.numberStars; j++) {
                    x += " <span class=\"icon star\"></span>";
                }
            } 
            x += "<br>";
            x += "<img src=\"https://png.icons8.com/material/50/000000/worldwide-location.png\" width=\"18px\" height=\"18px\">";
            x += "<span class=\"sity\"> " + myObj[i].touristDestination.placeDestination.city + "</span>";
            x += "<h3 class=\"cost\">" + myObj[i].tourCost + " руб</h3>";
            x += "<br>";
            x += "<button type=\"button\" class=\"btn btn-outline-primary btn-block\">Просмотреть</button>";
            x += "</div>";

            x += "<div class=\"col tour_info\">";

            x += "<div class=\"align-middle d-flex flex-column bd-highlight mb-3\" style=\"height: 100%;\">";

            x += "<div class=\"p-2 bd-highlight\">";
            x += "<img src=\"https://png.icons8.com/android/50/000000/room.png\" width=\"18px\" height=\"18px\">";
            x += " Вид номера: <span>" + myObj[i].touristDestination.room.roomName +"</span>";
            x += "</div>";
            x += "<div class=\"p-2 bd-highlight\">";
            x += "<img src=\"https://png.icons8.com/android/50/000000/restaurant.png\" width=\"18px\" height=\"18px\">";
            x += " Вид питания: <span>" + myObj[i].touristDestination.food.foodName + "</span>";
            x += "</div>";
            x += "<div class=\"mt-auto p-2 bd-highlight ml-auto\">";

            x += "<div class=\"btn-group\">";
            x +="<button class=\"btn btn-outline-primary dropdown-toggle\" type=\"button\" id=\"dropdownMenuButton\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\">Действия</button>";
            x += "<div class=\"dropdown-menu\" aria-labelledby=\"dropdownMenuButton\">"
            x += "<a class=\"dropdown-item\" href=\"#\">Редактировать</a>"
            x += "<a class=\"dropdown-item\" href=\"#\">Удалить</a>"
            x += "</div>";
            x += "</div>";

            x += "</div>";

            x += "</div>";

            x += "</div>";

            x += "</div>";
        }
        document.getElementById("blogsDiv").innerHTML = x;

        //for (i in myObj) {
        //    x2 += "<option value=" + myObj[i].blogId + ">" + myObj[i].blogId + "</option>";
        //}

        //document.getElementById("deleteDiv").innerHTML = x2;
    }
    //window.setInterval(LoadBlogs, 5000);