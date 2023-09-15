var mongoose = require("mongoose");

var userSchema = mongoose.Schema({
    fullname:{type:String, require:true},
    email:{type:String, require:true},
    phoneNumber:{type:String, require:true},
    licenseplate:{type:String, required:true},
    begindate:{type:Date, require:true},
    begintime:{type:String, require:true},
    enddate:{type:Date, require:true},
    endtime:{type:String, require:true},
});

module.exports = mongoose.model("User", userSchema);