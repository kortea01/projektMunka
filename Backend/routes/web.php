<?php

use Illuminate\Support\Facades\Http;
use Illuminate\Support\Facades\Route;
use App\Http\Controllers\MenuListerController;


/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider and all of them will
| be assigned to the "web" middleware group.  Make something great!
|
*/

Route::get('/', function () {
    return view('welcome');
});

Route::get('/proba', function () {
    return view('proba');
});

Route::get('/menu1', [MenuListerController::class, 'getData']);

Route::get('/menu2', function () {
    
    //$response = Http::get('https://microsoftedge.github.io/Demos/json-dummy-data/64KB.json');
    //$response = Http::connectTimeout(3)->acceptJson()->get('https://microsoftedge.github.io/Demos/json-dummy-data/64KB-min.json');
    $response = Http::connectTimeout(3)->acceptJson()->get('https://c2e62ff23d1049ae96c91eb27fd47232.api.mockbin.io');
    //$response = Http::connectTimeout(3)->acceptJson()->get('https://5e51e2d0d30746668995d577f2a44bd7.api.mockbin.io');
    //$response = Http::connectTimeout(3)->acceptJson()->get('https://a333509767d449edaa7c651691307108.api.mockbin.io'); // ha nincs [] között nem eszi meg
        
    //$response = Http::acceptJson()->get('localhost:8000/api/menu');


    
    // Check if the request was successful
    if ($response->successful()) {
        $menuItems = $response->json();        
    } else {
        // If the request failed, handle the error accordingly
        abort(500, 'Failed to fetch menu items');
    }
    
    
    // Render the view and pass the menu items to it
    return view('menu', ['menuItems' => $menuItems]);



    // Your logic to generate JSON data
    /*
        $data = [
            'name' => 'Pizza',
            'description' => 'Pizza ala mezon',
            'price' => '12'
        ];
        */

/*
    $url = "http://localhost:8000/api/menu";
    $ch = curl_init();
    curl_setopt($ch, CURLOPT_URL, $url);
    curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
    curl_setopt($ch, CURLOPT_MAXREDIRS, 10);
    curl_setopt($ch, CURLOPT_SSL_VERIFYPEER, false);
    curl_setopt($ch, CURLOPT_CUSTOMREQUEST, "GET");
    curl_setopt($ch, CURLOPT_HTTPHEADER, array ('Content-Type:application/json'));
    $curl_response = curl_exec($ch);
    $result = json_decode($curl_response, true);

    return view('menu');
*/


});
