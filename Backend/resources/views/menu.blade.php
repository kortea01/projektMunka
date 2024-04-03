<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Menu</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.7.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
</head>
<body>


<h1>Menu Items</h1>
    <table class="table table-striped">
        <thead>
            <tr>
                <th>Name</th>
                <th>Price</th>
                <th>Ingredients</th>
                <th>Other</th>
            </tr>
        </thead>
        <tbody>
            @foreach ($menuItems as $menuItem)
                <tr>
                    <td>{{ $menuItem['name'] }}</td>
                    <td>{{ $menuItem['language'] }}</td>
                    <td>{{ $menuItem['id'] }}</td>
                    <td>{{ $menuItem['bio'] }}</td>
                </tr>
            @endforeach
        </tbody>
    </table>

</body>
</html>
