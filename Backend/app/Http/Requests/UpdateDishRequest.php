<?php

namespace App\Http\Requests;

use Illuminate\Foundation\Http\FormRequest;

class UpdateDishRequest extends FormRequest
{
    /**
     * Determine if the user is authorized to make this request.
     */
    public function authorize(): bool
    {
        return true;
    }

    /**
     * Get the validation rules that apply to the request.
     *
     * @return array<string, \Illuminate\Contracts\Validation\ValidationRule|array<mixed>|string>
     */
    public function rules(): array
    {
        return [
            'name' => 'required|string|max:255',	
            'category' => 'required|string|in:soup,salad,pizza,pasta,dessert,drinks,risotto',
            'description' => 'required|string|max:255',
            'img_url' => 'nullable|string|max:255',	
            'ingredients' => 'required|array',
            'price' => 'required|numeric|min:0'
        ];
    }
}
