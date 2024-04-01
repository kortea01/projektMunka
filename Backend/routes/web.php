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
    
    /*
    $url = 'http://localhost:8000/api/menu'; 
    $response = file_get_contents($url);
    $apiData = json_decode($response);
    */

    /*
    //$response = Http::get('http://localhost:8000/api/menu');
    $response = Http::connectTimeout(3)->acceptJson()->get('http://localhost:8000/api/menu');
    
    // Check if the request was successful
    if ($response->successful()) {
        $menuItems = $response->json();
    } else {
        // If the request failed, handle the error accordingly
        abort(500, 'Failed to fetch menu items');
    }
    */

    // Your logic to generate JSON data
    /*
        $data = [
            'name' => 'Pizza',
            'description' => 'Pizza ala mezon',
            'price' => '12'
        ];        
        */


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

    // Render the view and pass the menu items to it
    return view('menu', ['menuItems' => $result]);
   // return view('menu');
});
