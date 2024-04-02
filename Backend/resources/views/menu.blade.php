<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Menu</title>
</head>
<body>
    <h1>Menu</h1>

    <ul>
        @foreach ($menuItems as $menuItem)
            <li>{{ $menuItem['name'] }} - {{ $menuItem['language'] }} - {{ $menuItem['id'] }} </li>
        @endforeach
    </ul>

</body>
</html>
