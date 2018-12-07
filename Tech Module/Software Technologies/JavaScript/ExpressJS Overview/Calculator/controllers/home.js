const Calculator = require('../models/Calculator');

module.exports = {
    indexGet: (req, res) => {
        res.render('home/index');
    },
    indexPost: (req, res) =>{
        let calcBody = req.body;

        console.log(calcBody);

        let calcParams = calcBody['calculator'];

        let Calc = new Calculator();

        Calc.leftOperand = Number(calcParams.leftOperand);
        Calc.operator = calcParams.operator;
        Calc.rightOperand = Number(calcParams.rightOperand);

        let result = Calc.calculateResult();

        res.render('home/index', {'calculator': Calc, 'result':result});
    },

};