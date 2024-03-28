<?php

use Illuminate\Http\Request;
#use App\Http\Controllers\AuthController;
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
Route::post('login', 'App\Http\Controllers\AuthController@login');
Route::post('register', 'App\Http\Controllers\AuthController@register');
Route::post('logout', 'App\Http\Controllers\AuthController@logout');

Route::get('menu', 'App\Http\Controllers\DishController@index');
Route::get('menu/{id}', 'App\Http\Controllers\DishController@show');
Route::get('menu/category/{category}', 'App\Http\Controllers\DishController@categoryIndex');

Route::get('ingredients', 'App\Http\Controllers\IngredientController@index');
Route::get('ingredients/{id}', 'App\Http\Controllers\IngredientController@show');

# protected endpoints

