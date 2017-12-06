// configuration de Passport
var LocalStrategy = require('passport-local').Strategy;
var mysql = require('mysql');
var bcrypt = require('bcrypt-nodejs');
var db = require('./database');

// on se connecte à la base de données pour commencer
var connection = mysql.createConnection(db.connection);
module.exports = function(passport) {

    // configuration des sessions Passport
    passport.serializeUser(function(user, done) {
        done(null, user.Login); // user.Login = clé primaire
    });

    passport.deserializeUser(function(id, done) {
        connection.query("SELECT * FROM UTILISATEUR WHERE Login = ? ",[id], function(err, rows){
            done(err, rows[0]);
        });
    });

    // inscription
    passport.use(
        'local-signup',
        new LocalStrategy({
            // le nom des champs qu'on récupère dans le formulaire
            usernameField : 'Login',
            passwordField : 'Mdp',
            passReqToCallback : true
        },
        function(req, username, password, done) {
            console.log("hello passport");
            // on vérifie si l'utilisateur existe déjà
            connection.query("SELECT * FROM UTILISATEUR WHERE Login = ?",[username], function(err, rows) {
                if (err) // échec de la requête
                    return done(err);
                if (rows.length) { // l'utilisateur existe déjà
                    return done(null, false);
                } else { // l'utilisateur n'existe pas
                    if(req.body.News){
                      var News=1;
                    }else {
                        var News=0
                    }
                    // on crée un nouvel utilisateur
                    var nouveUtilisateur = {
                        Login: username,
                        Mdp: bcrypt.hashSync(password, null, null),  // mot de passe en paramètre haché
                        Email: req.body.Email,
                        Nom: req.body.Nom,
                        Prenom: req.body.Prenom,
                        DateNaissance: req.body.DateNaissance,
                        News: News,
                        Nationalite: req.body.Nationalite,
                        Droits: 1
                    };

                    // préparation de la requête et insertion de l'utilisateur
                    var insertQuery = "INSERT INTO UTILISATEUR ( Login, Mdp, Email, Nom, Prenom, DateNaissance, News, Nationalite, Droits ) values (?,?,?,?,?,?,?,?,?)";

                    connection.query(insertQuery,[nouveUtilisateur.Login, nouveUtilisateur.Mdp, nouveUtilisateur.Email,nouveUtilisateur.Nom,nouveUtilisateur.Prenom,nouveUtilisateur.DateNaissance,nouveUtilisateur.News,nouveUtilisateur.Nationalite,nouveUtilisateur.Droits], function(err, rows) {
                        return done(null, nouveUtilisateur);
                    });
                }
            });
        })
    );

    // connexion
    passport.use(
        'local-login',
        new LocalStrategy({
            // toujours le nom des champs qu'on récupère dans le formulaire
            usernameField : 'Login',
            passwordField : 'Mdp',
            passReqToCallback : true
        },
        function(req, username, password, done) {
            connection.query("SELECT * FROM UTILISATEUR WHERE Login = ?",[username], function(err, rows){
                if (err) // échec de la requête
                    return done(err);
                if (!rows.length) { // l'utilisateur n'existe pas
                    return done(null, false);
                }

                // le mot de passe ne correspond pas
                if (!bcrypt.compareSync(password, rows[0].Mdp))
                    return done(null, false);

                // on renvoie l'utilisateur connecté
                console.log("Conexion reussis");
                return done(null, rows[0]);
            });
        })
    );
};
