<%@ Page Language="C#" Inherits="International_Web_Form.Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>5200 International Address Project</title>
</head>
<body>

<div>
    <h2>All Forms</h2>
    <ul id="forms" />
</div>
<div>
    <h2>Search by ID</h2>
    <input type="text" id="FormId" size="5" />
    <input type="button" value="Search" onclick="find();" />
    <p id="product" />
</div>

<script src="https://ajax.aspnetcdn.com/ajax/jQuery/jquery-2.0.3.min.js"></script>
<script>
    var uri = 'api/forms';

    $(document).ready(function () {
        // Send an AJAX request
        $.getJSON(uri)
            .done(function (data) {
                // On success, 'data' contains a list of products.
                $.each(data, function (key, item) {
                    // Add a list item for the product.
                    $('<li>', { text: formatItem(item) }).appendTo($('#forms'));
                });
            });
    });

    function formatItem(item) {
        return item.Country + ' ID:' + item.Id;
    }

    function find() {
        var id = $('#formId').val();
        $.getJSON(uri + '/' + id)
            .done(function (data) {
                $('#form').text(formatItem(data));
            })
            .fail(function (jqXHR, textStatus, err) {
                $('#form').text('Error: ' + err);
            });
    }
</script></body>
</html>