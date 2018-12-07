const db_url = 'https://phonebook-73a22.firebaseio.com/phonebook';
const TABLE = $('#phonebook');
const PERSON = $('#person');
const PHONE = $('#phone');

$('#btnLoad').on('click', loadContacts);
$('#btnCreate').on('click', createContact);

function loadContacts() {
  $.ajax({
      method: 'GET',
      url: db_url + '.json'
    }).then(appendContacts)
    .catch(handleError);

}

function appendContacts(contacts) {
  if (contacts) {
    let keys = Object.keys(contacts);
    keys.sort((a, b) => contacts[a].name.toString().localeCompare(contacts[b].name));
    TABLE.empty();
    for (const id of keys) {
      let li = $('<li>');
      li.text(`${contacts[id].name}: ${contacts[id].phone}`);
      let a = $('<a href="#">[Delete]</a>');
      a.on('click', function() {
        $.ajax({
          method: "DELETE",
          url: db_url + `/${id}.json`
        }).then(function() {
          li.remove();
        }).catch(handleError)
      });
      li.append(a);
      TABLE.append(li);
    }
  }
}

function createContact() {
  let name = PERSON.val();
  let phone = PHONE.val();

  if (name.trim() !== '' && phone.trim() !== '') {
    $.ajax({
      method: "POST",
      url: db_url + ".json",
      data: JSON.stringify({
        name,
        phone
      })
    }).then(function(res) {
      PERSON.val("");
      PHONE.val("");
      loadContacts();
    }).catch(handleError);
  }
}

function handleError(err) {
  console.error(err);
}
