import React from "react";
import Svg, { Path } from "react-native-svg";

export default function ActiveHome(props) {
  return (
    <Svg
      width="36"
      height="36"
      viewBox="0 0 36 36"
      fill="none"
      xmlns="http://www.w3.org/2000/svg"
    >
      <Path
        d="M28.4999 13.0649L20.5004 6.8429C19.7984 6.29676 18.9344 6.00024 18.0449 6.00024C17.1555 6.00024 16.2914 6.29676 15.5894 6.8429L7.58842 13.0649C7.10759 13.4388 6.71856 13.9177 6.45106 14.4649C6.18355 15.0122 6.04463 15.6133 6.04492 16.2224V27.0224C6.04492 27.818 6.36099 28.5811 6.9236 29.1437C7.48621 29.7063 8.24927 30.0224 9.04492 30.0224H27.0449C27.8406 30.0224 28.6036 29.7063 29.1662 29.1437C29.7289 28.5811 30.0449 27.818 30.0449 27.0224V16.2224C30.0449 14.9879 29.4749 13.8224 28.4999 13.0649Z"
        fill="#121212"
      />
      <Path
        d="M24 22.5C20.685 24.4995 15.312 24.4995 12 22.5"
        stroke="#FCFCFC"
        stroke-width="2.5"
        stroke-linecap="round"
        stroke-linejoin="round"
      />
    </Svg>
  );
}