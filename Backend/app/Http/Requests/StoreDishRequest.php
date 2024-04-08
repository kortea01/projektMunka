<?php

namespace App\Http\Requests;

use Illuminate\Foundation\Http\FormRequest;

class StoreDishRequest extends FormRequest
{
    /**
     * Determine if the user is authorized to make this request.
     */
    public function authorize(): bool
    {
        return false;
    }

    /**
     * Get the validation rules that apply to the request.
     *
     * @return array<string, \Illuminate\Contracts\Validation\ValidationRule|array<mixed>|string>
     */
    public function rules(): array
    {
        $rules = [
            'name' => 'required|string|max:255',	
            'category' => 'required|string|in:soup,salad,pizza,pasta,dessert,drinks,risotto',
            'description' => 'required|string|max:255',
            'img_url' => 'required|string|max:255',	
            'ingredients' => 'required|json',
            'price' => 'required|numeric|min:0'
        ];
        
        return $rules;
    }
}
