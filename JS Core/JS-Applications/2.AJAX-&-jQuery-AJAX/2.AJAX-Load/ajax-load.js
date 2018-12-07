$(document).ajaxError(function(event, req, settings) {
  console.log(req.status);
  console.log(req.statusText);
})

function loadTitle() {
  $('#text').load("https://softuni.bg/");
}
