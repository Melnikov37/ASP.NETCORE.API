   function DeleteTour(id) {
       var request = new XMLHttpRequest();
       url = "/api/ToursFull/" + id;
       request.open("DELETE", url, false);
       request.send();
       LoadTours();
   }

   function CreateTour() {
       arrivalDate = document.getElementById("inputArrivalDate").value;
       departureDate = document.getElementById("inputDepartureDate").value;
       cost = document.getElementById("inputCost").value;
       numberTransactions = document.getElementById("inputNumberTransactions").value;
       destinationId = document.getElementById("inputTouristDestinations").value;
       operatorId = document.getElementById("inputOperatorId").value;
       transportId = document.getElementById("inputTransportId").value;
       numberPersons = document.getElementById("inputNumberPersons").value;

       var xmlhttp = new XMLHttpRequest(); // new HttpRequest instance
       xmlhttp.open("POST", "/api/tours/");
       xmlhttp.setRequestHeader("Content-Type", "application/json;charset=UTF-8");
       xmlhttp.send(JSON.stringify({
           tourArrivalDate: arrivalDate,
           tourDepartureDate: departureDate,
           tourCost: cost,
           tourNumberTransactions: numberTransactions,
           touristDestinationId: destinationId,
           tourOperatorId: operatorId,
           transportId: transportId,
           tourNumberPersons: numberPersons,
           tourOperator: null,
           touristDestination: null,
           transport: null,
           deals: []
       }));
       LoadTours();
   }

   function LoadTuorOperator() {
       var request = new XMLHttpRequest();
       request.open("GET", "/api/TourOperators/", false);
       request.send();

       var myObj = JSON.parse(request.responseText);
       var selectText = "";
       selectText += "<label for=\"inputOperatorId\">Туроператор</label>";
       selectText += "<select class=\"form-control\" name=\"operator\" id=\"inputOperatorId\">";
       for (i in myObj) {
           selectText += "<option value=\"" + myObj[i].tourOperatorId + "\">" + myObj[i].tourOperatorName + "</option>";
       }
       selectText += "</select>";
       document.getElementById("selectOperatorId").innerHTML = selectText;
   }

   function LoadTransports() {
       var request = new XMLHttpRequest();
       request.open("GET", "/api/Transports/", false);
       request.send();

       var myObj = JSON.parse(request.responseText);
       var selectText = "";
       selectText += "<label for=\"inputTransportId\">Транспорт</label>";
       selectText += "<select class=\"form-control\" name=\"transport\" id=\"inputTransportId\">";
       for (i in myObj) {
           selectText += "<option value=\"" + myObj[i].transportId + "\">" + myObj[i].transportName + "</option>";
       }
       selectText += "</select>";
       document.getElementById("selectTransportId").innerHTML = selectText;
   }

   function LoadTouristDestinations() {
       var request = new XMLHttpRequest();
       request.open("GET", "/api/TouristDestinations/", false);
       request.send();

       var myObj = JSON.parse(request.responseText);
       var selectText = "";
       selectText += "<label for=\"inputTouristDestinations\">Отель</label>";
       selectText += "<select class=\"form-control\" name=\"touristDestinations\" id=\"inputTouristDestinations\">";
       for (i in myObj) {
           selectText += "<option value=\"" + myObj[i].touristDestinationId + "\">" + myObj[i].hotelName + " " + myObj[i].numberStars + "*, " + myObj[i].placeDestination.country + ", " + myObj[i].placeDestination.city + "</option>";
       }
       selectText += "</select>";
       document.getElementById("selectTouristDestinations").innerHTML = selectText;
   }

   function LoadTours() {
       var myObj, i, x = "";
       var request = new XMLHttpRequest();
       request.open("GET", "/api/ToursFull/", false);
       request.send();

       myObj = JSON.parse(request.responseText);
       x = "";
       for (i in myObj) {
           x += "<div class=\"row tour border-top\">";

           x += "<div class=\"col\">";
           x += "<img class=\"img-thumbnail\" src=\"" + myObj[i].touristDestination.photo.urlLlink + "\" width=\"100%\" height=\"100%\">";
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
           x += " Вид номера: <span>" + myObj[i].touristDestination.room.roomName + "</span>";
           x += "</div>";
           x += "<div class=\"p-2 bd-highlight\">";
           x += "<img src=\"https://png.icons8.com/android/50/000000/restaurant.png\" width=\"18px\" height=\"18px\">";
           x += " Вид питания: <span>" + myObj[i].touristDestination.food.foodName + "</span>";
           x += "</div>";
           x += "<div class=\"mt-auto p-2 bd-highlight ml-auto\">";

           x += "<div class=\"dropdown\">";
           x += "<button class=\"btn btn-outline-primary dropdown-toggle\" type=\"button\" id=\"dropdownMenu2\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\">Действия</button>";
           x += "<div class=\"dropdown-menu\" aria-labelledby=\"dropdownMenu2\">"
           x += "<button class=\"dropdown-item\" type=\"button\" data-toggle=\"modal\" data-target=\"#exampleModal\">Редактировать</button>";
           x += "<button class=\"dropdown-item\" type=\"button\" onclick=\"DeleteTour(" +
               myObj[i].tourId +
               ");\">Удалить</button>";
           x += "</div>";
           x += "</div>";

           x += "</div>";

           x += "</div>";

           x += "</div>";

           x += "</div>";
       }
       document.getElementById("blogsDiv").innerHTML = x;
   }
   window.setInterval(LoadTours, 5000);