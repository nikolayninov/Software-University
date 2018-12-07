function initializeTable() {
  $("#createLink").on('click', createCountry);
  addCountryToTable("Bulgaria", "Sofia");
  addCountryToTable("Germany", "Berlin");
  addCountryToTable("Russia", "Moscow");
  hideButtons();

  function addCountryToTable(country, town) {
    let tr = $("<tr>")
      .append(`<td>${country}</td>`)
      .append(`<td>${town}</td>`)
      .append($(`<td>`)
        .append($('<a href="#">[Up]</a>')
          .on("click", moveUp))
        .append($('<a href="#">[Down]</a>')
          .on("click", moveDown))
        .append($('<a href="#">[Delete]</a>')
          .on("click", deleteRow))
      );
    tr.css("display", "none");
    $("#countriesTable").append(tr);
    tr.fadeIn();
  }

  function createCountry(arguments) {
    let country = $('#newCountryText');
    let town = $('#newCapitalText');
    if (country.val().trim() && town.val().trim()) {
      addCountryToTable(country.val(), town.val());
      country.val('');
      town.val('');
    }
    hideButtons();
  }

  function moveUp() {
    let row = $(this).parent().parent();
    row.fadeOut(1000, function() {
      row.insertBefore(row.prev());
      hideButtons();
      row.fadeIn(1000);
    })


  }

  function moveDown() {
    let row = $(this).parent().parent();
    row.fadeOut(1000, function() {
      row.insertAfter(row.next());
      hideButtons();
      row.fadeIn(1000);
    })


  }

  function deleteRow() {
    $(this).fadeOut(1000, function() {
      $(this).parent().parent().remove();
      hideButtons();
    })
  }

  function hideButtons() {
    $("#countriesTable a").css("display", "inline");
    $("#countriesTable tr:eq(2) a:contains('Up')").css("display", "none");
    $("#countriesTable tr:last a:contains('Down')").css("display", "none");
  }
}
