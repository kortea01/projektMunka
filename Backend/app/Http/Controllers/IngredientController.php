<?php

namespace App\Http\Controllers;

use App\Http\Requests\StoreIngredientRequest;
use App\Http\Requests\UpdateIngredientRequest;
use App\Models\Ingredient;
use Illuminate\Http\Request;

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
    public function create()
    {
        //
    }

    /**
     * Store a newly created resource in storage.
     */
    public function store(StoreIngredientRequest $request)
    {
        //
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
        //
    }

    /**
     * Update the specified resource in storage.
     */
    public function update(UpdateIngredientRequest $request, Ingredient $ingredient)
    {
        //
    }

    /**
     * Remove the specified resource from storage.
     */
    public function destroy($id)
    {
        $ingredient = Ingredient::find($id);
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
            return response()->json(["message" => "Ingerdient Successfully saved.", $ingredient], 200);
        } else {
            return response()->json(["message" => "Ingerdient could not been saved"], 401);
        }
    }
}
