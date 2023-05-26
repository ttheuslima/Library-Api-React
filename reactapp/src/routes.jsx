import React from "react";
import { RouterProvider, createBrowserRouter } from "react-router-dom";
import { Home } from "./Pages/Home/home";
import { FormLogin } from "./Pages/FormLogin/form";
import { FormRegister } from "./Pages/FormRegister/form";

export function App() {
  const router = createBrowserRouter([
      {
          path:"/",
          element:<Home/>,
      },
      {
          path:"/login",
          element:<FormLogin/>,
      },
      {
          path:"/register",
          element:<FormRegister/>,
      },

      ]);
  // const router = createBrowserRouter([
  //   {
  //     path: "/",
  //     element: <Main />,
  //     children: [
  //       {
  //         path: "/",
  //         element: <Home />,
  //       },
  //       {
  //         path: "/login",
  //         element: <FormLogin />,
  //       },
  //       {
  //         path: "/register",
  //         element: <FormRegister />,
  //       },
  //     ],
  //   },
  // ]);   
  return (
    <div className="App">
      <RouterProvider router={router} />
    </div>
  );
}
