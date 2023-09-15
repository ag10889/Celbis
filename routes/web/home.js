var express = require("express");
var mongoose = require("mongoose");

var User = require("../../models/users");

var router = express.Router();

router.get("/", function (req,res) {
    console.log("Connection successful.");
    res.render("home/");
});

router.get("/home", function(req,res){
    res.render("home/home");
});

router.get("/reserve", function(req,res){
    res.render("home/reserve");
});

router.post('/submit', async function(req, res){
    var newUser = new User({
        fullname: req.body.fullname,
        email: req.body.email,
        phoneNumber: req.body.phoneNumber,
        licenseplate: req.body.licenseplate,
        begindate: req.body.begindate,
        begintime: req.body.begintime,
        enddate: req.body.enddate,
        endtime: req.body.endtime,
    });

    try {
        const savedUser = await newUser.save();
        console.log('Data inserted:', savedUser);
        res.send('Data inserted successfully');
    } catch (err) {
        console.error('Error inserting data:', err);
        res.status(500).send('Error inserting data');
    }
});

module.exports = router;