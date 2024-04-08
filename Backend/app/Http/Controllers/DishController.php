<?php

namespace App\Http\Controllers;

use App\Http\Controllers\Controller;
use App\Http\Requests\StoreDishRequest;
use App\Http\Requests\UpdateDishRequest;
use App\Models\Dish;
use App\Models\Ingredient;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Auth;

class DishController extends Controller
{
    /**
     * Display a listing of the resource.
     */
    public function index()
    {
        //
        return Dish::orderBy('category')->orderBy('name')->paginate(50);
        
    }
    public function listAll()
    {
        //
        return Dish::orderBy('category')->orderBy('name')->get()->toJson();
        
    }

    public function categoryIndex($category)
    {
        return Dish::where('category', $category)->orderBy('name')->paginate(50);
    }

    /**
     * Show the form for creating a new resource.
     */
    public function create(Request $request)
    {
        $user = Auth::user(); 
        if ($user->tokenCan('admin') || $user->tokenCan('manager')) {
            $dish = Dish::Create([
                'category' => $request->category,
                'name' => $request->name,
                'description' => $request->description,
                'img_url' => $request->image,
                'ingredients' => $request->ingredients,
                'price' => $request->price,
            ]);
            $dish->save(); // kell ez ide?
            return response()->json(["message" => "Dish Successfully updated.",$dish], 200);
        } else {
            return response()->json(["message" => "Unauthorized"], 401);
        }

    }

    /**
     * Store a newly created resource in storage.
     */
    public function store(StoreDishRequest $request)
    {
        $user = Auth::user(); 
        if ($user->tokenCan('admin') || $user->tokenCan('manager')) {
            $dish = Dish::Create([
                'category' => $request->category,
                'name' => $request->name,
                'description' => $request->description,
                'img_url' => $request->image,
                'ingredients' => $request->ingredients,
                'price' => $request->price,
            ]);
            $dish->save(); // kell ez ide ? omst akkor store vagy create ?
            return response()->json(["message" => "Dish Successfully updated.",$dish], 200);
        } else {
            return response()->json(["message" => "Unauthorized"], 401);
        }
    }

    /**
     * Display the specified resource.
     */
    public function show($id)
    {
        //
        $item = Dish::findOrFail($id);
        if (is_array($item->ingredients)) {
            $item->ingredients = Ingredient::whereIn('id', $item->ingredients)->get();
        }
        return $item;
    }

    /**
     * Show the form for editing the specified resource.
     */
    public function edit(Dish $dish)
    {
        //
    }

    /**
     * Update the specified resource in storage.
     */
    public function update(UpdateDishRequest $request, Dish $dish)
    {
        //
    }

    /**
     * Remove the specified resource from storage.
     */
    public function destroy(Dish $dish)
    {
        //
    }
}
