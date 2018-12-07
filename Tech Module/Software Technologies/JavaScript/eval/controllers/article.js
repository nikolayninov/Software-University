const Article = require('../models').Article;
const User = require('../models').User;

module.exports = {
    createGet: (req, res) => {
        res.render('article/create');
    },

    createPost: (req, res) => {
        let articleArgs = req.body;
        let title = req.body.title;
        let content = req.body.content;

        let errorMsg = '';

        if(!req.isAuthenticated()) {
            errorMsg = 'You should be logged in to make articles!'
        } else if (!articleArgs.title) {
            errorMsg = 'Invalid title!';
        }else if (!articleArgs.content) {
            errorMsg = 'Invalid content!';
        }
        if(errorMsg){
            res.render('article/create', {error: errorMsg, title, content});
            return;
        }
        articleArgs.authorId = req.user.id;

        Article.create(articleArgs).then(article => {
            res.redirect('/');
        }).catch(err => {
            console.log(err.message);
            res.render('article/create', {error: err.message});
    });

        const article = {
            title,
            content
        };
    },

    details: (req,  res) => {
        let id = Number(req.params.id);
        Article.findById(id, {include: [
                {
                    model: User,
                }
            ]
        }).then(article => {
            if (article === null) {
                throw new Error('Article not found: ' + articleId);
            }
            console.log(article);
            res.render('article/details', article.dataValues)
        }).catch(e => {
            console.log(e.message);
            res.redirect('/404');
        });
    }
};
