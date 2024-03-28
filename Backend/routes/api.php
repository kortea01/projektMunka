<?php

use Illuminate\Http\Request;
use Illuminate\Support\Facades\Route;

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
Route::post('login', 'App\Http\Controllers\Api\AuthController@login');
Route::post('register', 'App\Http\Controllers\Api\AuthController@register');
Route::post('logout', 'App\Http\Controllers\Api\AuthController@logout');

Route::get('menu', 'App\Http\Controllers\Api\DishController@index');
Route::get('menu/{id}', 'App\Http\Controllers\Api\DishController@show');
Route::get('menu/category/{category}', 'App\Http\Controllers\Api\DishController@categoryIndex');

Route::get('igredients', 'App\Http\Controllers\Api\IngredientController@index');
Route::get('igredient/{id}', 'App\Http\Controllers\Api\IngredientController@show');

# protected endpoints

