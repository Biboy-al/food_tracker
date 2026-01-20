import 'package:flutter/material.dart';
import 'package:frontend/widgets/AddForm.dart';

class AddMealWidget extends StatelessWidget{
  const AddMealWidget({super.key});

  @override
  Widget build(BuildContext context) {
    // TODO: implement build
    return Scaffold(
      

      body: Center(
        child:  Container(
        
          padding: EdgeInsets.all(20.0),
          child: Center(
            child: 
            AddForm()
            ),
          
        ),
        
      ),
    );
  }
 


  
}