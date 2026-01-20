import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:frontend/formFields/intFormField.dart';

class AddForm extends StatefulWidget{
  const AddForm({super.key});

  @override
  AddFormState createState() => AddFormState();
  
}

class AddFormState extends State<AddForm>{

    // Form state is an object assoicated with a form widget.
    // Serves as a container and controller for managing
    // multiple form fields
  final _formKey = GlobalKey<FormState>();

  String _name = "";
  int _fiber = 0;
  int _carbs = 0;
  int _protien = 0;
  int _fats = 0;

  @override
  Widget build(BuildContext context) {
  
    return Form(
      key: _formKey,
      child: Column(
        children: [
          TextFormField(
            
            decoration: InputDecoration(
              labelText: "Name of Food"
  
            ),

            validator: (value){
              if(value == null || value.isEmpty){
                return "Please Enter Somthing";
              }
              return null;
            },

            onSaved: (newValue) => {
              _name = newValue!
            },
          ),

         IntFormField(

          label: "Fiber", 

          hintText: "Type in kg",

          validator: (value){
             if(value == null || value.isEmpty){
                return "Please Enter Somthing";
              }
          },
          onSaved: (newValue) => {
            _fiber = int.parse(newValue!)
          }),

          IntFormField(

            label: "Fats",

            validator: (value){
             if(value == null || value.isEmpty){
                return "Please Enter Somthing";
              }
          },
            onSaved: (newValue) => {
              _fats = int.parse(newValue!)
            },
          ),

          IntFormField(

            label: "Protien",
          
            validator: (value){
             if(value == null || value.isEmpty){
                return "Please Enter Somthing";
              }
            },
            onSaved: (newValue) => {
              _protien = int.parse(newValue!)
            },
          ),

          IntFormField(

              label: "Carbs",

            validator: (value){
             if(value == null || value.isEmpty){
                return "Please Enter Somthing";
              }
          },
          onSaved: (newValue) => {
            _carbs = int.parse(newValue!)
          }),


          ElevatedButton(
            onPressed: () {


        
              if(_formKey.currentState!.validate()){
                _formKey.currentState!.save();
                print('$_fiber');
                print('$_name');
                print('$_carbs');
                print('$_fats');
                print('$_protien');

                Navigator.of(context).pop(); // close dialog
                // A function that pushes the alert dialog to stack
                showDialog(
                  context: context,
                  builder: (BuildContext context) {
                    return AlertDialog(
                      title: const Text("Success"),
                      content: const Text("Food successfully created!"),
                      actions: [
                        TextButton(
                          onPressed: () {
                            Navigator.of(context).pop(); // close dialog
                          },
                          child: const Text("Done"),
                        ),
                      ],
                    );
                  },
                );


              }
            },
          
          child: Text("Submit"),
          
          )
        ],
      )
    );
  }


}