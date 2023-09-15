const express = require('express');
const path = require("path");
var mongoose = require("mongoose");
var cookieParser = require("cookie-parser");
var session = require("express-session");
var bodyParser = require("body-parser");


var app = express();
mongoose.connect('mongodb+srv://amohsen:k9ehvkt4DDU5RWQy@cluster0.icnr2ar.mongodb.net/?retryWrites=true&w=majority');

app.set("port", process.env.PORT || 3000);
app.set("views", path.join(__dirname, "views"));
app.set("view engine", "ejs");
app.use(bodyParser.urlencoded({extended:false}));
app.use(cookieParser());
app.use(session({
    secret:"jasdfgfhjnkldgsdfklgaskdjfgklsadfg",
    resave:false,
    saveUniinitialized:false
}));

app.use("/", require("./routes/web"));
app.use("/api", require ("./routes/api"));

app.listen (app.get("port"),function() {
    console.log("Server started on port " + app.get("port"));
});