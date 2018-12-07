const Sequelize = require('sequelize');


module.exports = function(sequelize){
    const Article = sequelize.define('Article',{

        title: {
          type: Sequelize.STRING,
          required: true,
          allowNul:false,
        },
        content:{
          type: Sequelize.TEXT,
          required: true,
          allowNul:false,
        },
        date:{
          type: Sequelize.DATE,
          required: true,
          defaultValue:Sequelize.NOW,
        }
    });

    Article.associate = function(models){
      Article.belongsTo(models.User,{
        foreignKey: 'authorId',
        targetKey: 'id'
      });
    };

    return Article;
};
