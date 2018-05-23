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

    var xmlhttp = new XMLHttpRequest();
    xmlhttp.onload = function(ev) {
        var msg = "";
        alert(xmlhttp.status);
        if (xmlhttp.status == 404) {
            msg = "У вас не хватает прав для добавления";
        } else if (xmlhttp.status == 201) {
            msg = "Запись добавлена";
        } else {
            msg = "Неизвестная ошибка";
        }
        document.getElementById("msgAdd").innerHTML = msg;
    };
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

function EditTour(tourID) {
    arrivalDate = document.getElementById("inputArrivalDate").value;
    departureDate = document.getElementById("inputDepartureDate").value;
    cost = document.getElementById("inputCost").value;
    numberTransactions = document.getElementById("inputNumberTransactions").value;
    destinationId = document.getElementById("inputTouristDestinations").value;
    operatorId = document.getElementById("inputOperatorId").value;
    transportId = document.getElementById("inputTransportId").value;
    numberPersons = document.getElementById("inputNumberPersons").value;

    var xmlhttp = new XMLHttpRequest(); // new HttpRequest instance
    xmlhttp.open("PUT", "/api/tours/" + tourID);
    xmlhttp.setRequestHeader("Content-Type", "application/json;charset=UTF-8");
    xmlhttp.send(JSON.stringify({
        tourId: tourID.toString(),
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

function LoadTuorOperator(selectId) {
    var request = new XMLHttpRequest();
    request.open("GET", "/api/TourOperators/", false);
    request.send();

    var myObj = JSON.parse(request.responseText);
    var selectText = "";
    selectText += "<label for=\"inputOperatorId\">Туроператор</label>";
    selectText += "<select class=\"form-control\" name=\"operator\" id=\"inputOperatorId\">";
    for (i in myObj) {
        if (selectId == myObj[i].tourOperatorId) {
            selectText += "<option selected value=\"" + myObj[i].tourOperatorId + "\">" + myObj[i].tourOperatorName + "</option>";
        } else {
            selectText += "<option value=\"" + myObj[i].tourOperatorId + "\">" + myObj[i].tourOperatorName + "</option>";
        }
    }
    selectText += "</select>";
    document.getElementById("selectOperatorId").innerHTML = selectText;
}

function LoadTransports(selectID) {
    var request = new XMLHttpRequest();
    request.open("GET", "/api/Transports/", false);
    request.send();

    var myObj = JSON.parse(request.responseText);
    var selectText = "";
    selectText += "<label for=\"inputTransportId\">Транспорт</label>";
    selectText += "<select class=\"form-control\" name=\"transport\" id=\"inputTransportId\">";
    for (i in myObj) {
        if (selectID == myObj[i].transportId) {
            selectText += "<option selected value=\"" + myObj[i].transportId + "\">" + myObj[i].transportName + "</option>";
        } else {
            selectText += "<option value=\"" + myObj[i].transportId + "\">" + myObj[i].transportName + "</option>";
        }
    }
    selectText += "</select>";
    document.getElementById("selectTransportId").innerHTML = selectText;
}

function LoadTouristDestinations(selectID) {
    var request = new XMLHttpRequest();
    request.open("GET", "/api/TouristDestinations/", false);
    request.send();

    var myObj = JSON.parse(request.responseText);
    var selectText = "";
    selectText += "<label for=\"inputTouristDestinations\">Отель</label>";
    selectText += "<select class=\"form-control\" name=\"touristDestinations\" id=\"inputTouristDestinations\">";
    for (i in myObj) {
        if (selectID == myObj[i].touristDestinationId) {
            if (myObj[i].numberStars != null) {
                selectText += "<option selected value=\"" + myObj[i].touristDestinationId + "\">" + myObj[i].hotelName + " " + myObj[i].numberStars + "*, " + myObj[i].placeDestination.country + ", " + myObj[i].placeDestination.city + "</option>";
    
            } else {
                selectText += "<option selected value=\"" + myObj[i].touristDestinationId + "\">" + myObj[i].hotelName + ", " + myObj[i].placeDestination.country + ", " + myObj[i].placeDestination.city + "</option>";
            }
        }else {
            if (myObj[i].numberStars != null) {
                selectText += "<option value=\"" + myObj[i].touristDestinationId + "\">" + myObj[i].hotelName + " " + myObj[i].numberStars + "*, " + myObj[i].placeDestination.country + ", " + myObj[i].placeDestination.city + "</option>";
    
            } else {
                selectText += "<option value=\"" + myObj[i].touristDestinationId + "\">" + myObj[i].hotelName + ", " + myObj[i].placeDestination.country + ", " + myObj[i].placeDestination.city + "</option>";
            }
        }
    }
    selectText += "</select>";
    document.getElementById("selectTouristDestinations").innerHTML = selectText;
}
function ButtonEdit(tourID) {
    var tour = tourID;
    document.getElementById("saveButtom").onclick = function() {
        EditTour(tour);
    };
}
function ButtonAdd() {
    document.getElementById("saveButtom").onclick = function() {
        CreateTour();
    };
}
function LoadTour(tourID) {
    var request = new XMLHttpRequest();
    request.open("GET", "/api/ToursFull/" + tourID, false);
    request.send();

    var myObj = JSON.parse(request.responseText);
    LoadTouristDestinations(myObj.touristDestinationId);
    document.getElementById("inputArrivalDate").value = myObj.tourArrivalDate;
    document.getElementById("inputDepartureDate").value = myObj.tourDepartureDate;
    document.getElementById("inputCost").value = myObj.tourCost;
    document.getElementById("inputNumberTransactions").value = myObj.tourNumberTransactions;
    LoadTransports(myObj.transportId);
    LoadTuorOperator(myObj.tourOperatorId);
    document.getElementById("inputNumberPersons").value = myObj.tourNumberPersons;
    ButtonEdit(tourID);
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
        x += "<div class=\"dropdown-menu\" aria-labelledby=\"dropdownMenu2\">";
        x += "<button class=\"dropdown-item\" type=\"button\" data-toggle=\"modal\" data-target=\"#exampleModal\" onclick=\"LoadTour("+ myObj[i].tourId +");\">Редактировать</button>";
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

function Login() {
    email = document.getElementById("EmailLogin").value;
    password = document.getElementById("PasswordLogin").value;
    var xmlhttp = new XMLHttpRequest();
    xmlhttp.open("POST", "/api/Account/Login");
    xmlhttp.setRequestHeader("Content-Type", "application/json;charset=UTF8");
    document.getElementById("msgLogin").innerHTML = "";
    document.getElementById('formErrorLogin').innerHTML = "";
    xmlhttp.onload = function () {
        myObj = JSON.parse(this.responseText);
        if (myObj.error == undefined) {
            $('#loginModal').modal('hide');
            document.getElementById("msg").innerHTML = "";
            document.getElementById('formError').innerHTML = "";
            document.getElementById('Email').innerHTML = "";
            GetCurrentUser();
        } else {
            if (typeof myObj.error !== "undefined" && myObj.error.length > 0) {
                for (var i = 0; i < myObj.error.length; i++) {
                    var ul = document.getElementsByTagName("ul");
                    var li = document.createElement("li");
                    li.appendChild(document.createTextNode(myObj.error[i]));
                    ul[0].appendChild(li);
                }
            }
        }

        document.getElementById("msgLogin").innerHTML = myObj.message;
        document.getElementById("Password").value = "";
    };

    xmlhttp.send(JSON.stringify({
        email: email,
        password: password
    }));
    GetCurrentUser();
};

function Register() {
    email = document.getElementById("Email").value;
    password = document.getElementById("Password").value;
    passwordConfirm = document.getElementById("PasswordConfirm").value;
    var xmlhttp = new XMLHttpRequest();
    xmlhttp.open("POST", "/api/account/Register");
    xmlhttp.setRequestHeader("Content-Type", "application/json;charset=UTF8");
    document.getElementById("msg").innerHTML = "";
    document.getElementById('formError').innerHTML = "";
    xmlhttp.onload = function () {
        myObj = JSON.parse(this.responseText);
        if (myObj.error == undefined) {
            $('#registerModal').modal('hide');
            document.getElementById("msg").innerHTML = "";
            document.getElementById('formError').innerHTML = "";
            document.getElementById('Email').innerHTML = "";
            GetCurrentUser();
        } else {
            var mydiv = document.getElementById('formError');
            while (mydiv.firstChild) {
                mydiv.removeChild(mydiv.firstChild);
            }
            if (myObj.error.length > 0) {
                for (var i = 0; i < myObj.error.length; i++) {
                    var ul = document.getElementsByTagName("ul");
                    var li = document.createElement("li");
                    li.appendChild(document.createTextNode(myObj.error[i]));
                    ul[0].appendChild(li);
                }
            }
        }
        document.getElementById("msg").innerHTML = myObj.message;
        document.getElementById("Password").value = "";
        document.getElementById("PasswordConfirm").value = "";
    };
    // Запрос на сервер
    xmlhttp.send(JSON.stringify({
        email: email,
        password: password,
        passwordConfirm: passwordConfirm
    }));
};

function LoginOff() {
    var xmlhttp = new XMLHttpRequest();
    xmlhttp.open("POST", "api/Account/LogOff", true);
    xmlhttp.onload = function() {
                GetCurrentUser();
    };
    xmlhttp.send();
}

function GetCurrentUser() {
    var xmlhttp = new XMLHttpRequest();
    xmlhttp.open("POST", "/api/Account/isAuthenticated", true);
    xmlhttp.onload = function() {
            AutenXmlHTTP = JSON.parse(xmlhttp.responseText);
            SetStatus(AutenXmlHTTP.boolen, AutenXmlHTTP.name);
    };
    xmlhttp.send();
}

function SetStatus(status, name) {
    if (status === false) {
        UnLogMenu();
    }
    if (status === true) {
        LogMenu(name);
    }
}

function UnLogMenu() {
    var html = "";
    html += "<div class=\"d-flex flex-row bd-highlight\">";
    html += "<div class=\"p-2 bd-highlight\">";
    html += "<button type=\"button\" class=\"btn btn-block\" data-toggle=\"modal\" data-target=\"#registerModal\" style=\"background-color: #FFFF00;\"><img src=\"https://png.icons8.com/ultraviolet/50/000000/add-user-male.png\" weight=\"22px\" height=\"22px\">Зарегистрироваться</button>";
    html += "</div>";
    html += "<div class=\"p-2 bd-highlight\">";
    html +=
        "<button type=\"button\" class=\"btn btn-block\" data-toggle=\"modal\" data-target=\"#loginModal\" style=\"background-color: #FFFF00;\"><img src=\"https://png.icons8.com/ultraviolet/50/000000/enter-2.png\" weight=\"22px\" height=\"22px\">Войти</button>";
    html += "</div>";
    html += "</div>";
    document.getElementById("login").innerHTML = html;
    document.getElementById("registerBtn").addEventListener("click", Register);
    document.getElementById("loginBtn").addEventListener("click", Login);
}

function LogMenu(name) {
    var html = "";
    html += "<div class=\"btn-group\" role=\"group\">";
    html += "<button id=\"btnGroupDrop1\" type=\"button\" class=\"btn btn-light dropdown-toggle\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\"  style=\"background-color: #FFFF00;\">";
    html += "<span class=\"navbar-toggler-icon\"></span>";
    html += "</button>";
    html += "<div class=\"dropdown-menu\" aria-labelledby=\"btnGroupDrop1\">";
    html += "<img src=\"data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAADIAAAAyCAYAAAAeP4ixAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAJeSURBVGhD7drfa45hHMfxx49N1NRSFKUm/8B25sDIgYgIpeYApZxJlJId4IScmTWhlFIK+dVaa0hrObMxP1KM4QglP/IjI7P3tzl6+lj3fT3Xve+l+dTrYPV0P5+7nntd3+u6SxEzDRtxEb14ittoQSP+iazHa/wewxVUI9nsxjBU+XIPcRdd2IbJSCIrkfUmlEuYAtdMxQuognnshWs2QBXL6x2q4JZbUMVCrIJLZuIXVKkQx+CSZVCFQnXCJfaAqkKhBuAS+ymoQqFewSXHoQqFcruRw1CFQj2ASzZDFQrl9rDPRcx/vwfhkoV4D1UqxBG4ZD9UoVB34JLYD/sgXLILqlCofrhkEVShUEfhEpvs7OegSuX1FfPhluX4AFUujx1wzwL8gCqYhdtPSuUmVMksGpBMQpcrfUgqtgnxEqrsWNYguayDKvs3tq+VbM5DlS73HXVINluhipdrR9I5AVW83HUkG3twf0IVVw5hNtwzHfaA25HBPYTu/z7GSazGuO7UL8Y5fIYqVgkb1NpgQ1thWQEbflSB2GyEvoCoC8l5uAr1hUX7hj2YhIpix2VvoL5kPF3GDATF9naHoC7s4RpyHwjNQYw5I7Z9yJVWqAt5+4QaZE6sEbYIS5A5lRxuFm0TMkddIBUT80Zibk7HthaZY7O0uog3G9xsrM4c29mws291MQ9PsAVBsTWWLdG/QF28aB9xFra8j/K+Si2acBrPUNTz8xYdaIaNCvbKVKGxgaoe9l7WTtjxwhnYsttm8Rvogb2vdR/P8ejP392wz5zCAWzHUszC/4ymVBoBFDNEae17I/kAAAAASUVORK5CYII=\" width=\"23px\" height=\"23px\">";
    html += "<span>" + name + "</span>";
    html += "<a class=\"dropdown-item\" href=\"#\">Мой аккаунт</a>";
    html += "<a class=\"dropdown-item\" href=\"#\">Мои записи</a>";
    html += "<a id=\"login-off\"class=\"dropdown-item\" href=\"#\">Выйти</a>";
    html += "</div>";
    html += "</div>";
    document.getElementById("login").innerHTML = html;
    document.getElementById("login-off").addEventListener("click",
        LoginOff);
}
window.setInterval(LoadTours, 5000);