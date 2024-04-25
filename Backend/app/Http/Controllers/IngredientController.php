<?php

namespace App\Http\Controllers;

use App\Http\Requests\StoreIngredientRequest;
use App\Http\Requests\UpdateIngredientRequest;
use App\Models\Ingredient;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Auth;
use Illuminate\Support\Facades\Hash;

class IngredientController extends Controller
{
    /**
     * Display a listing of the resource.
     */
    public function index()
    {
        //
        return Ingredient::orderBy('name')->paginate(50);
    }
    public function listAll()
    {
        //
        return Ingredient::all()->toJson();

    }
    /**
     * Show the form for creating a new resource.
     */
    public function create(StoreIngredientRequest $request)
    {
        $user = Auth::user(); 
        if ($user->tokenCan('admin') || $user->tokenCan('manager')) {
            $ingredient = Ingredient::create([
                'name' =>       $request->name,
                'allergen' =>   $request->allergen,
                'in_stock'  =>  $request->in_stock
            ]);
            return response()->json(["message" => "Ingredient Successfully created.", $ingredient], 201);
        } else {
            return response()->json(["message" => "Unauthorized"], 401);
        }
    }

    /**
     * Store a newly created resource in storage.
     */
    public function store(StoreIngredientRequest $request)
    {
        // ... using create instead
    }

    /**
     * Display the specified resource.
     */
    public function show($id)
    {
        //
        $item = Ingredient::findOrFail($id);
        return $item;
    }

    /**
     * Show the form for editing the specified resource.
     */
    public function edit(Ingredient $ingredient)
    {
        // using update instead
    } 

    /**
     * Update the specified resource in storage.
     */
    public function update(UpdateIngredientRequest $request, $id)
    {
        $user = Auth::user(); 
        if ($user->tokenCan('admin') || $user->tokenCan('manager')) {
            $target = Ingredient::findOrFail($id);
            $target->update($request->all());
            return response()->json(["message" => "Ingredient Successfully updated.", $target], 201);
        } else {
            return response()->json(["message" => "Unauthorized"], 401);
        }
        //return response()->json("dafuq");

    }
    /**
     * Remove the specified resource from storage.
     */
    public function destroy($id)
    {
        $user = Auth::user(); 
        if ($user->tokenCan('admin') || $user->tokenCan('manager')) {
            $target = Ingredient::findOrFail($id);
            $target->delete();
            return response()->json(["message" => "Ingredient Successfully deleted."], 200);
        } else {
            return response()->json(["message" => "Unauthorized"], 401);
        }
    }
    /**
     * Remove the specified resource from storage.
     */
    public function destroy_no_auth($id)
    {
        $ingredient = Ingredient::findOrFail($id);
        if ($ingredient) {
            $ingredient->delete();
            return response()->json(['message' => 'Ingredient deleted successfully'], 200);
        } else {
            return response()->json(['message' => 'Ingredient not found'], 404);
        }
    }

    public function create_no_auth(Request $request)
    {
        $ingredient = Ingredient::Create([
            'name' => $request->name,
            'allergen' => $request->allergen,
            'in_Stock'  => $request->in_stock,
        ]);

        if ($ingredient) {
            $ingredient->save();
            return response()->json(["message" => "Ingerdient successfully saved.", $ingredient], 200);
        } else {
            return response()->json(["message" => "Ingerdient could not been saved"], 401);
        }
    }

    public function update_no_auth(Request $request, $id)
    {
        $ingredient = Ingredient::findOrFail($id);
        if ($ingredient) {
            $ingredient->name =   $request->name;
            $ingredient->allergen = $request->allergen;
            $ingredient->in_stock = $request->in_stock;
            $ingredient->save();
            return response()->json(["message" => "Ingredient successfully updates.", $ingredient], 200);
        } else {
            return response()->json(["message" => "Ingredient not found"], 401);
        }
    }
}

