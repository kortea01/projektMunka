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
# login/register
Route::post('login', 'App\Http\Controllers\AuthController@login');          // ok
Route::post('register', 'App\Http\Controllers\AuthController@register');    // ok

# DISHED
# read:
Route::get('menu', 'App\Http\Controllers\DishController@index');                              // ok
Route::get('menu-all', 'App\Http\Controllers\DishController@listAll');                        // ok
Route::get('menu/{id}', 'App\Http\Controllers\DishController@show')->where('id', '[0-9]+');   // ok
Route::get('menu/category/{category}', 'App\Http\Controllers\DishController@categoryIndex');  // ok
# write
Route::delete('menu-all/{id}', 'App\Http\Controllers\DishController@destroy_no_auth')->where('id', '[0-9]+');       //ok
Route::post('menu-all', 'App\Http\Controllers\DishController@create_no_auth');                              // ok
Route::put('menu-all/{id}', 'App\Http\Controllers\DishController@update_no_auth')->where('id', '[0-9]+');

# INGRED
# read:
Route::get('ingredients', 'App\Http\Controllers\IngredientController@index');                                   // ok
Route::get('ingredients-all', 'App\Http\Controllers\IngredientController@listAll');                             // ok
Route::get('ingredients/{id}', 'App\Http\Controllers\IngredientController@show')->where('id', '[0-9]+');        // ok
# write:
Route::delete('ingredients-all/{id}', 'App\Http\Controllers\IngredientController@destroy_no_auth')->where('id', '[0-9]+'); // ok
Route::post('ingredients-all', 'App\Http\Controllers\IngredientController@create_no_auth'); //ok
Route::put('ingredients-all/{id}', 'App\Http\Controllers\IngredientController@update_no_auth')->where('id', '[0-9]+'); //???



# protected endpoints
Route::middleware('auth:sanctum')->group(function () {
    Route::post('logout', 'App\Http\Controllers\AuthController@logout');        // ? destory current token / invalidate session?
    Route::post('logout-everywhere', 'App\Http\Controllers\AuthController@logoutEverywhere'); // ? destory all tokens / invalidate all sessions?

    # user mgmt
    Route::get('user', 'App\Http\Controllers\Api\UserController@index');                                // ok
    Route::get('user-all', 'App\Http\Controllers\Api\UserController@listAll');                          // ok
    Route::get('user/{id}', 'App\Http\Controllers\Api\UserController@show')->where('id', '[0-9]+');     // ok
    Route::put('user/{id}', 'App\Http\Controllers\Api\UserController@update')->where('id', '[0-9]+');   // ok
    Route::delete('user/{id}', 'App\Http\Controllers\Api\UserController@destroy')->where('id', '[0-9]+'); // ok

    # menu mgmt
    Route::post('menu', 'App\Http\Controllers\DishController@create'); // create or store ?             // ok 
    Route::put('menu/{id}', 'App\Http\Controllers\DishController@update')->where('id', '[0-9]+');       // ok
    Route::delete('menu/{id}', 'App\Http\Controllers\DishController@destroy')->where('id', '[0-9]+');   // ok

    # ingred mgmt
    Route::post('ingredients', 'App\Http\Controllers\IngredientController@create'); // create or store ?            // ok
    Route::put('ingredients/{id}', 'App\Http\Controllers\IngredientController@update')->where('id', '[0-9]+');      // ok
    Route::delete('ingredients/{id}', 'App\Http\Controllers\IngredientController@destroy')->where('id', '[0-9]+');  // ok

    # order mgmt
    Route::get('orders-all', 'App\Http\Controllers\OrderController@listAll');                          // noauth 
   
    Route::get('orders', 'App\Http\Controllers\OrderController@index');                                // todo
    Route::get('orders/{id}', 'App\Http\Controllers\OrderController@show')->where('id', '[0-9]+');     // todo
    Route::post('orders', 'App\Http\Controllers\OrderController@create');                               // todo
    Route::put('orders/{id}', 'App\Http\Controllers\OrderController@update')->where('id', '[0-9]+');   // todo
    Route::delete('orders/{id}', 'App\Http\Controllers\OrderController@destroy')->where('id', '[0-9]+'); // todo

}
);
