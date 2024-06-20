
//------------------------------ Inventory total size----------------------------------

$(document).ready(function () {
    // Attach input event handler to each input field with class 'float-input'
    $('.float-input').on('input', function () {
        var total = 1; // Initialize total to 1 for multiplication

        // Iterate through each input field and multiply their parsed float values
        $('.float-input').each(function () {
            var value = parseFloat($(this).val());
            // Multiply the parsed float value to total if it's a valid number
            if (!isNaN(value)) {
                total *= value;
            }
        });

        // Display the total in the 'total' input field
        $('#total').val(total);
    });
});

$(document).ready(function () {
    var dataTable = $('#example').DataTable();

    $('#movingButton').click(function () {
        var nameFilter = 'Moving';
        if (nameFilter !== '') {
            dataTable.column(0).search(nameFilter).draw();
        } else {
            dataTable.column(0).search('').draw();
        }

        var table = document.getElementById("example");
        var rows = table.rows;

        for (var i = 0; i < rows.length; i++) {
            var cells = rows[i].cells;
            cells[7].style.display = ""; // Hide column 7
            cells[8].style.display = ""; // Hide column 8
            cells[9].style.display = ""; // Hide column 9
            cells[10].style.display = ""; // Hide column 10

        }
    });
    $('#cleaningButton').click(function () {
        var nameFilter = 'Cleaning';
        if (nameFilter !== '') {
            dataTable.column(0).search(nameFilter).draw();
        } else {
            dataTable.column(0).search('').draw();
        }

        var table = document.getElementById("example");
        var rows = table.rows;

        for (var i = 0; i < rows.length; i++) {
            var cells = rows[i].cells;
            cells[7].style.display = "none"; // Hide column 7
            cells[8].style.display = "none"; // Hide column 8
            cells[9].style.display = "none"; // Hide column 9
            cells[10].style.display = "none"; // Hide column 10

        }
    });
    $('#MoveandCleanButton').click(function () {
        var nameFilter = 'Move And Clean';
        if (nameFilter !== '') {
            dataTable.column(0).search(nameFilter).draw();
        } else {
            dataTable.column(0).search('').draw();
        }

        var table = document.getElementById("example");
        var rows = table.rows;

        for (var i = 0; i < rows.length; i++) {
            var cells = rows[i].cells;
            cells[7].style.display = ""; // Hide column 7
            cells[8].style.display = ""; // Hide column 8
            cells[9].style.display = ""; // Hide column 9
            cells[10].style.display = ""; // Hide column 10

        }
    });
    $('#paintingButton').click(function () {
        var nameFilter = 'Painting';
        if (nameFilter !== '') {
            dataTable.column(0).search(nameFilter).draw();
        } else {
            dataTable.column(0).search('').draw();
        }

        var table = document.getElementById("example");
        var rows = table.rows;

        for (var i = 0; i < rows.length; i++) {
            var cells = rows[i].cells;
            cells[7].style.display = "none"; // Hide column 7
            cells[8].style.display = "none"; // Hide column 8
            cells[9].style.display = "none"; // Hide column 9
            cells[10].style.display = "none"; // Hide column 10

        }
    });
    $('#gisperButton').click(function () {

        var nameFilter = 'Gisper';
        if (nameFilter !== '') {
            dataTable.column(0).search(nameFilter).draw();
        } else {
            dataTable.column(0).search('').draw();
        }

        var table = document.getElementById("example");
        var rows = table.rows;

        for (var i = 0; i < rows.length; i++) {
            var cells = rows[i].cells;
            cells[7].style.display = "none"; // Hide column 7
            cells[8].style.display = "none"; // Hide column 8
            cells[9].style.display = "none"; // Hide column 9
            cells[10].style.display = "none"; // Hide column 10

        }
    });

   
    $('#viewAllButton').click(function () {
        dataTable.column(0).search('').draw(); // Clear the search filter

        var table = document.getElementById("example");
        var rows = table.rows;

        for (var i = 0; i < rows.length; i++) {
            var cells = rows[i].cells;
            cells[7].style.display = ""; // Show column 7
            cells[8].style.display = ""; // Show column 8
            cells[9].style.display = ""; // Show column 9
            cells[10].style.display = ""; // Show column 10
        }
    });
});