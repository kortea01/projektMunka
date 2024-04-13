<?php

use Illuminate\Http\Request;
#use App\Http\Controllers\AuthController;
use Illuminate\Support\Facades\Route;
use App\Http\Controllers\Api\UserController;

/*
|--------------------------------------------------------------------------
| API Routes
|--------------------------------------------------------------------------
|
| Here is where you can register API routes for your application. These
| routes are loaded by the RouteServiceProvider and all of them will
| be assigned to the "api" middleware group. Make something great!
|
*/

# Route::middleware('auth:sanctum')->get('/user', function (Request $request) {
#     return $request->user();
# });
#

# public endpoints
Route::post('login', 'App\Http\Controllers\AuthController@login');          // ok
Route::post('register', 'App\Http\Controllers\AuthController@register');    // ok

Route::get('menu', 'App\Http\Controllers\DishController@index');                              // ok
Route::get('menu-all', 'App\Http\Controllers\DishController@listAll');                        // ok
Route::get('menu/{id}', 'App\Http\Controllers\DishController@show')->where('id', '[0-9]+');   // ok
Route::get('menu/category/{category}', 'App\Http\Controllers\DishController@categoryIndex');  // ok
Route::delete('menu-all/{id}', 'App\Http\Controllers\DishController@destroy')->where('id', '[0-9]+'); //ok

Route::get('ingredients', 'App\Http\Controllers\IngredientController@index');                                   // ok
Route::get('ingredients-all', 'App\Http\Controllers\IngredientController@listAll');                             // ok
Route::get('ingredients/{id}', 'App\Http\Controllers\IngredientController@show')->where('id', '[0-9]+');        // ok

# protected endpoints
Route::middleware('auth:sanctum')->group(function () {
    Route::post('logout', 'App\Http\Controllers\AuthController@logout');        // ? destory tokens / invaidate session?
    Route::post('logout-everywhere', 'App\Http\Controllers\AuthController@logoutEverywhere'); // ? destory all tokens / invaidate all sessions?

    Route::get('user', 'App\Http\Controllers\Api\UserController@index');                                // ok
    Route::get('user-all', 'App\Http\Controllers\Api\UserController@listAll');                          // ok
    Route::get('user/{id}', 'App\Http\Controllers\Api\UserController@show')->where('id', '[0-9]+');     // ok
    Route::put('user/{id}', 'App\Http\Controllers\Api\UserController@update')->where('id', '[0-9]+');   // TODO! FROM THIS POINT

    Route::post('menu', 'App\Http\Controllers\DishController@create'); // create or store ?
    Route::put('menu/{id}', 'App\Http\Controllers\DishController@update')->where('id', '[0-9]+');
    Route::delete('menu/{id}', 'App\Http\Controllers\DishController@destroy')->where('id', '[0-9]+');

    Route::post('ingredients', 'App\Http\Controllers\IngredientController@store');
    Route::put('ingredients/{id}', 'App\Http\Controllers\IngredientController@update')->where('id', '[0-9]+');
    Route::delete('ingredients/{id}', 'App\Http\Controllers\IngredientController@destroy')->where('id', '[0-9]+');
}
);
